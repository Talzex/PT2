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
    /*
     * Classe administrateur représentant la page de l'admin
     */
    public partial class Administrator : Form
    {

        MusiquePT2_MEntities musique;
        OpAdministator Opa;
        public decimal n;

        /*
         * Constructeur de Administrator
         */ 
        public Administrator()
        {
            InitializeComponent();
            musique = new MusiquePT2_MEntities();
            chargerDataGridViewAbonnés();
            Opa = new OpAdministator(musique);
            n = numericUpDown1.Value;
        }

        private void chargerDataGridViewAbonnés()
        {
            Opa = new OpAdministator(musique);
            var abo = (from a in musique.ABONNÉS
                       select a).ToList();
            Abonnés.Rows.Clear();

            foreach (ABONNÉS a in abo)
            {
                if (!(a.EMPRUNTER.Count.Equals(0)))
                {
                    foreach (EMPRUNTER e in a.EMPRUNTER)
                    {
                        Abonnés.Rows.Add(a.LOGIN_ABONNÉ, a.NOM_ABONNÉ, a.PRÉNOM_ABONNÉ, Opa.dernierEmprunt(a),
                            e.ALBUMS.TITRE_ALBUM, e.DATE_EMPRUNT, e.DATE_RETOUR_ATTENDUE, e.DATE_RETOUR);
                    }
                }
                else
                {
                    Abonnés.Rows.Add(a.LOGIN_ABONNÉ, a.NOM_ABONNÉ, a.PRÉNOM_ABONNÉ);
                }
            }
            colorRefresh();
        }

        /*
         * ConsulEmpProlongé_Click() permet d'afficher les emprunts prolongés
         */
        private void ConsulEmpProlongé_Click(object sender, EventArgs e)
        {
            Abonnés.Rows.Clear();

            foreach (EMPRUNTER emp in Opa.EmpruntProlonge())
            {
                ABONNÉS a = emp.ABONNÉS;
                Abonnés.Rows.Add(a.LOGIN_ABONNÉ, a.NOM_ABONNÉ, a.PRÉNOM_ABONNÉ, Opa.dernierEmprunt(a),
                    emp.ALBUMS.TITRE_ALBUM, emp.DATE_EMPRUNT, emp.DATE_RETOUR_ATTENDUE, emp.DATE_RETOUR);
            }
            colorRefresh();
        }

        /*
         * Purgeur_Click() permet de purger les abonnées
         */
        private void Purgeur_Click(object sender, EventArgs e)
        {

            chargerDataGridViewAbonnés();
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

        /*
         * RetardsRetourEmprunt_Click() permet d'afficher les retards de retour d'emprunts 
         */
        private void RetardsRetourEmprunt_Click(object sender, EventArgs e)
        {
            Abonnés.Rows.Clear();

            if (Opa.RetardEmprunt(n).Count() != 0)
            {
                foreach (EMPRUNTER emp in Opa.RetardEmprunt(n))
                {
                    ABONNÉS a = emp.ABONNÉS;
                    Abonnés.Rows.Add(a.LOGIN_ABONNÉ, a.NOM_ABONNÉ, a.PRÉNOM_ABONNÉ, Opa.dernierEmprunt(a),
                        emp.ALBUMS.TITRE_ALBUM, emp.DATE_EMPRUNT, emp.DATE_RETOUR_ATTENDUE, emp.DATE_RETOUR);
                    
                }
            }
            else
            {
                MessageBox.Show("Aucun Emprunt en retard");          
            }
            colorRefresh();

        }

        /*
         * AlbumNonEmp_Click() permet d'afficher les albums non empruntés
         */
        private void AlbumNonEmp_Click(object sender, EventArgs e)
        {
            Abonnés.Rows.Clear();

            if (Opa.AlbumsNonEmprunte(n).Count() != 0)
            {
                foreach (ALBUMS al in Opa.AlbumsNonEmprunte(n))
                {
                    foreach (EMPRUNTER emp in al.EMPRUNTER)
                    {
                        ABONNÉS a = emp.ABONNÉS;

                        Abonnés.Rows.Add(a.LOGIN_ABONNÉ, a.NOM_ABONNÉ, a.PRÉNOM_ABONNÉ, Opa.dernierEmprunt(a),
                           emp.ALBUMS.TITRE_ALBUM, emp.DATE_EMPRUNT, emp.DATE_RETOUR_ATTENDUE, emp.DATE_RETOUR);

                    }
                }
            }
            else
            {
                MessageBox.Show("Aucun Album ne figure dans la plage horaire");
            }
            colorRefresh();
        }

        /*
         * TopAlbumEmp_Click() permet d'afficher les 10 albums les plus empruntés
         */
        private void TopAlbumEmp_Click(object sender, EventArgs e)
        {
            Abonnés.Rows.Clear();

            if (Opa.TopAlbums().Count() != 0)
            {
                foreach (String al in Opa.TopAlbums())
                {
                    Abonnés.Rows.Add("", "", "", "", al);
                }
            }
            else
            {
                MessageBox.Show("Aucun Album n'a été encore emprunté");
            }

            colorRefresh();

        }

        /*
         * colorRefresh() permet de refresh les couleurs de la grille 
         */
        private void colorRefresh()
        {
            foreach (DataGridViewRow row in Abonnés.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.Azure;
            }
        }
    }
}
