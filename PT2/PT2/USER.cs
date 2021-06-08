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
    public partial class USER : Form
    {
        MusiquePT2_MEntities musique;
        ABONNÉS abonne;
        OpUSER opu;
        public USER(int code)
        {
            InitializeComponent();
            musique = new MusiquePT2_MEntities();
            var a = from j in musique.ABONNÉS
                    where j.CODE_ABONNÉ == code
                    select j;
            this.abonne = a.First();
            chargerListBoxEmprunter();
            chargerListBoxDisques();
            opu = new OpUSER(musique);
        }

        private void chargerListBoxEmprunter()
        {
            var emprunt = (from j in musique.EMPRUNTER
                           where j.CODE_ABONNÉ == abonne.CODE_ABONNÉ
                           select j).ToList();
            listEmprunt.Items.Clear();
            foreach (EMPRUNTER j in emprunt)
            {
                listEmprunt.Items.Add(j);
            }
        }

        private void chargerListBoxDisques()
        {
            var disques = (from j in musique.ALBUMS
                           select j).ToList();
            ListeDisques.Items.Clear();
            foreach(ALBUMS e in disques)
            {
                ListeDisques.Items.Add(e);
            }
        }

        private void retourne_Click(object sender, EventArgs e)
        {
            if (listEmprunt.SelectedItem != null)
            {
                EMPRUNTER titremprunt = (EMPRUNTER)listEmprunt.SelectedItem;
                opu.retourner(titremprunt);
                chargerListBoxEmprunter();
            }
        }

        private void emprunt_Click(object sender, EventArgs e)
        {

            if (ListeDisques.SelectedItem != null)
            {
                ALBUMS a = (ALBUMS)ListeDisques.SelectedItem;
                opu.emprunte(a,abonne);
                chargerListBoxEmprunter();
            }
        }

        /*private void ConsulE_Click(object sender, EventArgs e)
            {
                if (listEdition.SelectedItem != null)
                {
                    ABONNÉS j = (ABONNÉS)listEdition.SelectedItem;
                    var albumemprunt = from alb in musique.ALBUMS
                                       join f in musique.EMPRUNTER
                                       on alb.CODE_ALBUM equals f.CODE_ALBUM
                                       where f.CODE_ABONNÉ == j.CODE_ABONNÉ
                                       orderby f.DATE_RETOUR_ATTENDUE
                                       select alb;
                    var dateemprunt = from f in musique.EMPRUNTER
                                      where f.CODE_ABONNÉ == j.CODE_ABONNÉ
                                      select f;
                    if (dateemprunt.Count() != 0 || albumemprunt.Count() != 0)
                        MessageBox.Show(albumemprunt.First().TITRE_ALBUM + dateemprunt.First().DATE_RETOUR_ATTENDUE.ToString() + " " + dateemprunt.First().DATE_RETOUR.ToString());
                }

        }*/

        private void Prolongation_Click(object sender, EventArgs e)
        {
            if (listEmprunt.SelectedItem != null)
            {
                EMPRUNTER albumsEmprunte = (EMPRUNTER)listEmprunt.SelectedItem;
                opu.prolongation(albumsEmprunte);
                chargerListBoxEmprunter();
            }
        }
    }
}
