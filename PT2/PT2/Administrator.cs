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
            chargerListBoxAbonne();
            chargerListBoxRetards();
            Opa = new OpAdministator(musique);
            n = numericUpDown1.Value;
        }

        private void chargerListBoxRetards()
        {
            var emprunt = (from emp in musique.EMPRUNTER
                           select emp).ToList();
            listEmprunt.Items.Clear();
            foreach (EMPRUNTER p in emprunt)
            {
                listEmprunt.Items.Add(p.ToString());
            }
        }

        private void chargerListBoxAbonne()
        {   
            Opa = new OpAdministator(musique);
            var abo = (from p in musique.ABONNÉS
                       select p).ToList();
            listAbonne.Items.Clear();
            foreach (ABONNÉS p in abo)
            {
                listAbonne.Items.Add(p.ToString() + Opa.dernierEmprunt(p));
            }
        }

        private void ConsulEmpProlongé_Click(object sender, EventArgs e)
        {
            listEmprunt.Items.Clear();
            foreach (EMPRUNTER emp in Opa.EmpruntProlonge())
            {
                listEmprunt.Items.Add(emp);
            }
        }



        private void Purgeur_Click(object sender, EventArgs e)
        {
            string message = "Êtes vous sur de vouloir purger ?";
            string caption = "Error Detected in Input";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Opa.Purge(n);
                chargerListBoxAbonne();
            }
          

        }

        private void RetardsRetourEmprunt_Click(object sender, EventArgs e)
        {
            listEmprunt.Items.Clear();
            if (Opa.RetardEmprunt(n).Count() != 0)
            {
                foreach (EMPRUNTER emp in Opa.RetardEmprunt(n))
                {
                    listEmprunt.Items.Add(emp);
                }
            }
            else
            {
                listEmprunt.Items.Add("Aucun Emprunt en retard");
            }

        }

        private void AlbumNonEmp_Click(object sender, EventArgs e)
        {
            listEmprunt.Items.Clear();
            if (Opa.AlbumsNonEmprunte(n).Count() != 0)
            {
                foreach (ALBUMS al in Opa.AlbumsNonEmprunte(n))
                {
                    listEmprunt.Items.Add(al);
                }
            }
            else
            {
                listEmprunt.Items.Add("Aucun Album ne figure dans la plage horaire");
            }

        }

        private void TopAlbumEmp_Click(object sender, EventArgs e)
        {
            listEmprunt.Items.Clear();
            if (Opa.TopAlbums().Count() != 0)
            {
                foreach (String al in Opa.TopAlbums())
                {
                    listEmprunt.Items.Add(al);
                }
            }
            else
            {
                listEmprunt.Items.Add("Aucun Album n'a été encore emprunté");
            }

        }

    }
}
