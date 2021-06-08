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
        List<EMPRUNTER> empruntsNonRapportes;
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
            EmpruntsNonRapportes();
            listProlongement.Items.Clear();
            foreach (EMPRUNTER e in empruntsNonRapportes)
            {
                listProlongement.Items.Add(e.ALBUMS.TITRE_ALBUM);
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

        public void EmpruntsNonRapportes()
        {
            empruntsNonRapportes = new List<EMPRUNTER>();
            var emprunts = (from j in musique.EMPRUNTER
                            select j).ToList();
            foreach (EMPRUNTER e in emprunts)
            {
                if (e.DATE_RETOUR == null && DateTime.Now.Day - e.DATE_RETOUR_ATTENDUE.Day >= 10)
                {
                    empruntsNonRapportes.Add(e);
                }
            }
        }

        private void ConsulEmpProlongé_Click(object sender, EventArgs e)
        {
            listProlongement.Items.Clear();
            foreach (EMPRUNTER emp in Opa.EmpruntProlonge())
            {
                listProlongement.Items.Add(emp);
            }   
        }

        private void RefreshRetards_Click(object sender, EventArgs e)
        {
            chargerListBoxRetards();
        }

        

        private void Purgeur_Click(object sender, EventArgs e)
        {
            Opa.Purge();
            chargerListBoxAbonne();
            
        }

    }
}
