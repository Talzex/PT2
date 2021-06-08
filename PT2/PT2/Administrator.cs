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

        public Administrator()
        {
            InitializeComponent();
            musique = new MusiquePT2_MEntities();
            chargerListBoxAbonne();
            chargerListBoxRetards();
            Opa = new OpAdministator(musique);
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
            var abo = (from p in musique.ABONNÉS
                         select p).ToList();
            listAbonne.Items.Clear();
            foreach (ABONNÉS p in abo)
            {
                listAbonne.Items.Add(p.ToString());
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
            Opa.Purge();
            chargerListBoxAbonne();
            
        }

        private void RetardsRetourEmprunt_Click(object sender, EventArgs e)
        {
            listEmprunt.Items.Clear();
            if (Opa.RetardEmprunt().Count() != 0)
            {
                foreach (EMPRUNTER emp in Opa.RetardEmprunt())
                {
                    listEmprunt.Items.Add(emp);
                }
            } else
            {
                listEmprunt.Items.Add("Aucun Emprunt en retard");
            }
            
        }

        private void AlbumNonEmp_Click(object sender, EventArgs e)
        {
            listEmprunt.Items.Clear();
            if(Opa.AlbumsNonEmprunte().Count() != 0) {
                foreach (ALBUMS al in Opa.AlbumsNonEmprunte())
                {
                    listEmprunt.Items.Add(al);
                }
            } else
            {
                listEmprunt.Items.Add("Aucun Album ne figure dans la plage horaire");
            }
            
        }

        private void TopAlbumEmp_Click(object sender, EventArgs e)
        {
            listEmprunt.Items.Clear();
            if(Opa.TopAlbums().Count() != 0)
            {
                foreach (String al in Opa.TopAlbums())
                {
                    listEmprunt.Items.Add(al);
                }
            } else
            {
                listEmprunt.Items.Add("Aucun Album n'a été encore emprunté");
            }
            
        }
    }
}
