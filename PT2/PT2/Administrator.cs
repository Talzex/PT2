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
            chargerDataGridViewEmprunts();
            Opa = new OpAdministator(musique);
            n = numericUpDown1.Value;
        }

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
            Emprunts.Rows.Clear();

            foreach (EMPRUNTER emp in Opa.EmpruntProlonge())
            {
                GridViewEmpruntAdd(emp);

            }
        }

        private void Purgeur_Click(object sender, EventArgs e)
        {

            chargerDataGridViewEmprunts();
            string message = "Êtes vous sur de vouloir purger ?";
            string caption = "Error Detected in Input";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Opa.Purge(n);
            }
          

        }

        private void RetardsRetourEmprunt_Click(object sender, EventArgs e)
        {
            Emprunts.Rows.Clear();

            if (Opa.RetardEmprunt(n).Count() != 0)
            {
                foreach (EMPRUNTER emp in Opa.RetardEmprunt(n))
                {
                    GridViewEmpruntAdd(emp);
                }
            }
            else
            {
                string none = "Aucun Emprunt en retard";
                MessageBox.Show(none);
                colorRefresh();
            }

        }

        private void AlbumNonEmp_Click(object sender, EventArgs e)
        {
            Emprunts.Rows.Clear();

            if (Opa.AlbumsNonEmprunte(n).Count() != 0)
            {
                foreach (ALBUMS al in Opa.AlbumsNonEmprunte(n))
                {
                    var emprunter = from emp in musique.EMPRUNTER
                                    where al.CODE_ALBUM == emp.CODE_ALBUM
                                    select emp;
                    GridViewEmpruntAdd(emprunter.First());    
                }
            }
            else
            {
                string none = "Aucun Album ne figure dans la plage horaire";
                MessageBox.Show(none);
                colorRefresh();
            }
        }

        private void TopAlbumEmp_Click(object sender, EventArgs e)
        {
            Emprunts.Rows.Clear();

            if (Opa.TopAlbums().Count() != 0)
            {
                foreach (String al in Opa.TopAlbums())
                {
                    Emprunts.Rows.Add(al);
                    colorRefresh();
                }
            }
            else
            {
                string none = "Aucun Album n'a été encore emprunté";
                MessageBox.Show(none);
                colorRefresh();
            }

        }

        private void GridViewEmpruntAdd(EMPRUNTER e)
        {
            Emprunts.Rows.Add(e.ALBUMS.TITRE_ALBUM, e.DATE_EMPRUNT, e.DATE_RETOUR_ATTENDUE, e.DATE_RETOUR, e.ABONNÉS.LOGIN_ABONNÉ,e.ABONNÉS.NOM_ABONNÉ, e.ABONNÉS.PRÉNOM_ABONNÉ,  Opa.dernierEmprunt(e.ABONNÉS));
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
