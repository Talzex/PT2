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
            chargerDataGridViewEmprunts();
            Opa = new OpAdministator(musique);
            n = numericUpDown1.Value;
        }

        /*
         * chargerDataGridViewEmprunts() permet d'afficher sous forme de grille une liste 
         */
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

        /*
         * ConsulEmpProlongé_Click() permet d'afficher les emprunts prolongés
         */
        private void ConsulEmpProlongé_Click(object sender, EventArgs e)
        {
            Emprunts.Rows.Clear();

            foreach (EMPRUNTER emp in Opa.EmpruntProlonge())
            {
                GridViewEmpruntAdd(emp);

            }
        }

        /*
         * Purgeur_Click() permet de purger les abonnées
         */
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

        /*
         * RetardsRetourEmprunt_Click() permet d'afficher les retards de retour d'emprunts 
         */
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

        /*
         * AlbumNonEmp_Click() permet d'afficher les albums non empruntés
         */
        private void AlbumNonEmp_Click(object sender, EventArgs e)
        {
            Emprunts.Rows.Clear();

            if (Opa.AlbumsNonEmprunte(n).Count() != 0)
            {
                foreach (ALBUMS al in Opa.AlbumsNonEmprunte(n))
                {

                    //GridViewEmpruntAdd();    
                }
            }
            else
            {
                string none = "Aucun Album ne figure dans la plage horaire";
                MessageBox.Show(none);
                colorRefresh();
            }
        }

        /*
         * TopAlbumEmp_Click() permet d'afficher les 10 albums les plus empruntés
         */
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

        /*
         * GridViewEmpruntAdd() permet d'ajouter les éléments par rapport aux noms de colonnes
         */
        private void GridViewEmpruntAdd(EMPRUNTER e)
        {
            Emprunts.Rows.Add(e.ALBUMS.TITRE_ALBUM, e.DATE_EMPRUNT, e.DATE_RETOUR_ATTENDUE, e.DATE_RETOUR, e.ABONNÉS.LOGIN_ABONNÉ,e.ABONNÉS.NOM_ABONNÉ, e.ABONNÉS.PRÉNOM_ABONNÉ,  Opa.dernierEmprunt(e.ABONNÉS));
            colorRefresh();
        }

        /*
         * colorRefresh() permet de refresh les couleurs de la grille 
         */
        private void colorRefresh()
        {
            foreach (DataGridViewRow row in Emprunts.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.Azure;
            }
        }

    }
}
