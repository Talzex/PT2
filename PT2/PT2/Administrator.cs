using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PT2
{
    public partial class Administrator : Form
    {

        MusiquePT2_MEntities musique;
        OpAdministator Opa;
        public decimal n;
        public Administrator()
        {
            InitializeComponent();
            musique = new MusiquePT2_MEntities();
            //chargerListBoxAbonne();
            //chargerListBoxRetards();
            chargerDataGridViewEmprunts();
            Opa = new OpAdministator(musique);
            n = numericUpDown1.Value;
        }

        //private void chargerListBoxRetards()
        //{
        //    var emprunt = (from emp in musique.EMPRUNTER
        //                   select emp).ToList();
        //    listEmprunt.Items.Clear();
        //    foreach (EMPRUNTER p in emprunt)
        //    {
        //        listEmprunt.Items.Add(p.ToString());
        //    }
        //}

        //private void chargerListBoxAbonne()
        //{
        //    Opa = new OpAdministator(musique);
        //    var abo = (from p in musique.ABONNÉS
        //               select p).ToList();
        //    listAbonne.Items.Clear();
        //    foreach (ABONNÉS p in abo)
        //    {
        //        listAbonne.Items.Add(p.ToString() + Opa.dernierEmprunt(p));
        //    }
        //}
        private void chargerDataGridViewEmprunts()
        {
            Opa = new OpAdministator(musique);
            var emp = (from e in musique.EMPRUNTER
                       select e).ToList();
            Emprunts.Rows.Clear();

            foreach (EMPRUNTER e in emp)
            {
                GridViewEmpruntAdd(e);
            }
        }

        private void ConsulEmpProlongé_Click(object sender, EventArgs e)
        {
            //listEmprunt.Items.Clear();
            Emprunts.Rows.Clear();

            foreach (EMPRUNTER emp in Opa.EmpruntProlonge())
            {
                //listEmprunt.Items.Add(emp);
                GridViewEmpruntAdd(emp);

            }
        }

        private void Purgeur_Click(object sender, EventArgs e)
        {
            Opa.Purge();
            //chargerListBoxAbonne();
            chargerDataGridViewEmprunts();
        }

        private void RetardsRetourEmprunt_Click(object sender, EventArgs e)
        {
            //listEmprunt.Items.Clear();
            Emprunts.Rows.Clear();

            if (Opa.RetardEmprunt().Count() != 0)
            {
                foreach (EMPRUNTER emp in Opa.RetardEmprunt(n))
                {
                    //listEmprunt.Items.Add(emp);
                    GridViewEmpruntAdd(emp);
                }
            }
            else
            {
                string none = "Aucun Emprunt en retard";
                //listEmprunt.Items.Add(none);
                MessageBox.Show(none);
                colorRefresh();
            }

        }

        private void AlbumNonEmp_Click(object sender, EventArgs e)
        {
            //listEmprunt.Items.Clear();
            Emprunts.Rows.Clear();

            if (Opa.AlbumsNonEmprunte().Count() != 0)
            {
                foreach (ALBUMS al in Opa.AlbumsNonEmprunte(n))
                {
                    //listEmprunt.Items.Add(al);
                    var emprunter = from emp in musique.EMPRUNTER
                                    where al.CODE_ALBUM == emp.CODE_ALBUM
                                    select emp;
                    GridViewEmpruntAdd(emprunter.First());    
                }
            }
            else
            {
                string none = "Aucun Album ne figure dans la plage horaire";
                //listEmprunt.Items.Add(none);
                MessageBox.Show(none);
                colorRefresh();
            }
        }

        private void TopAlbumEmp_Click(object sender, EventArgs e)
        {
            //listEmprunt.Items.Clear();
            Emprunts.Rows.Clear();

            if (Opa.TopAlbums().Count() != 0)
            {
                foreach (String al in Opa.TopAlbums())
                {
                    //listEmprunt.Items.Add(al);
                    Emprunts.Rows.Add(al);
                    colorRefresh();
                }
            }
            else
            {
                string none = "Aucun Album n'a été encore emprunté";
                //listEmprunt.Items.Add(none);
                MessageBox.Show(none);
                colorRefresh();
            }

        }

        private void GridViewEmpruntAdd(EMPRUNTER e)
        {
            Emprunts.Rows.Add(e.ALBUMS.TITRE_ALBUM, e.DATE_EMPRUNT, e.DATE_RETOUR_ATTENDUE, e.DATE_RETOUR, e.ABONNÉS.LOGIN_ABONNÉ, e.CODE_ABONNÉ, e.ABONNÉS.NOM_ABONNÉ, e.ABONNÉS.PRÉNOM_ABONNÉ,  Opa.dernierEmprunt(e.ABONNÉS));
            colorRefresh();
        }

        private void colorRefresh()
        {
            foreach (DataGridViewRow row in Emprunts.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.Azure;
            }
        }

    }
}
