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
        public USER(ABONNÉS a)
        {
            InitializeComponent();
            musique = new MusiquePT2_MEntities();
            chargerListBoxEmprunter();
            this.abonne = a;
        }

        private void chargerListBoxEmprunter()
        {
            var emprunt = (from j in abonne.EMPRUNTER
                           where j.CODE_ABONNÉ == abonne.CODE_ABONNÉ
                           select j).ToList();
            listEmprunt.Items.Clear();
            foreach (EMPRUNTER j in emprunt)
            {
                listEmprunt.Items.Add(j);
            }
        }

        private void retourne_Click(object sender, EventArgs e)
        {
            if (listEmprunt.SelectedItem != null)
            {
                EMPRUNTER titremprunt = (EMPRUNTER)listEmprunt.SelectedItem;
                var emprunt = from a1 in musique.EMPRUNTER
                              where a1.ALBUMS.TITRE_ALBUM == titremprunt.ALBUMS.TITRE_ALBUM
                              select a1;
                titremprunt.DATE_RETOUR = DateTime.Now;
                musique.SaveChanges();
                chargerListBoxEmprunter();
            }
        }

        private void emprunt_Click(object sender, EventArgs e)
        {

            if (ListeDisques.SelectedItem != null)
            {
                EMPRUNTER emprunt = new EMPRUNTER();

                ALBUMS a = (ALBUMS)ListeDisques.SelectedItem;
                bool emprunté = false;
                emprunt.CODE_ABONNÉ = abonne.CODE_ABONNÉ;
                emprunt.DATE_EMPRUNT = DateTime.Now;
                emprunt.CODE_ALBUM = a.CODE_ALBUM;
                var delaiAlbum = from a2 in musique.ALBUMS
                                 where a2.CODE_ALBUM == a.CODE_ALBUM
                                 join p in musique.GENRES
                                 on a2.CODE_GENRE equals p.CODE_GENRE
                                 select p.DÉLAI;
                emprunt.DATE_RETOUR_ATTENDUE = DateTime.Now.AddDays((double)delaiAlbum.First());
                foreach (EMPRUNTER emp in abonne.EMPRUNTER)
                {
                    if (emprunt.CODE_ALBUM == emp.CODE_ALBUM && !emprunté)
                    {
                        emprunté = true;
                    }
                }
                if (!emprunté)
                {
                    musique.EMPRUNTER.Add(emprunt);
                    musique.SaveChanges();
                    chargerListBoxEmprunter();
                }

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

                if (!Prolonge(albumsEmprunte) && albumsEmprunte.DATE_RETOUR == null)
                {
                    albumsEmprunte.DATE_RETOUR_ATTENDUE = albumsEmprunte.DATE_RETOUR_ATTENDUE.AddMonths(1);
                    musique.SaveChanges();
                    MessageBox.Show(albumsEmprunte.ALBUMS.TITRE_ALBUM + " " + albumsEmprunte.DATE_RETOUR_ATTENDUE);
                    chargerListBoxEmprunter();
                }
            }
        }
        private bool Prolonge(EMPRUNTER j)
        {
            return j.DATE_EMPRUNT.Month + 1 == j.DATE_RETOUR_ATTENDUE.Month;
        }
    }
}
