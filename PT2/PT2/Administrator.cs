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

        public Administrator()
        {
            InitializeComponent();
            musique = new MusiquePT2_MEntities();
            chargerListBoxPurge();
            chargerListBoxRetards();
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

        private void chargerListBoxPurge()
        {
            var purge = (from p in musique.ABONNÉS
                         select p.NOM_ABONNÉ).ToList();
            listPurge.Items.Clear();
            foreach (String p in purge)
            {
                listPurge.Items.Add(p);
            }
        }

        public void EmpruntsNonRapportes()
        {
            empruntsNonRapportes = new List<EMPRUNTER>();
            var emprunts = (from j in musique.EMPRUNTER
                            select j).ToList();
            foreach (EMPRUNTER e in emprunts)
            {
                if (e.DATE_RETOUR == null && DateTime.Now.Day - e.DATE_RETOUR_ATTENDUE.Day >= 1)
                {
                    empruntsNonRapportes.Add(e);
                }
            }
        }

        private void ConsulEmpProlongé_Click(object sender, EventArgs e)
        {
            var emprunt = (from j in musique.EMPRUNTER
                           select j
                           ).ToList();
            foreach (EMPRUNTER j in emprunt)
            {
                if(Prolonge(j))
                {
                    MessageBox.Show(j.ToString());
                }

            }
        }

        private void RefreshRetards_Click(object sender, EventArgs e)
        {
            chargerListBoxRetards();
        }

        private bool Prolonge(EMPRUNTER j)
        {
            return j.DATE_EMPRUNT.Month + 1 == j.DATE_RETOUR_ATTENDUE.Month;
        }

        private void Purgeur_Click(object sender, EventArgs e)
        {
            var abo = from a in musique.ABONNÉS
                      join emp in musique.EMPRUNTER
                      on a.CODE_ABONNÉ equals emp.CODE_ABONNÉ
                      where 2023  /*DateTime.Now.Year*/  - emp.DATE_EMPRUNT.Year >= 1
                      select a;
            foreach (ABONNÉS a in abo)
            {
                //musique.ABONNÉS.Remove(a);
                chargerListBoxPurge();

            }
            //musique.SaveChanges();
            //chargerListBoxAbonnees();
        }
    }
}
