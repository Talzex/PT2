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

    public partial class Form1 : Form
    {
        MusiquePT2_MEntities musique;
        List<EMPRUNTER> empruntsNonRapportes;

        public Form1()
        {
            InitializeComponent();
            musique = new MusiquePT2_MEntities();
            chargerListBoxAbonnees();
            chargerListBoxEmprunter();
            chargerListBoxRetards();
        }

        private void chargerListBoxAbonnees()
        {
            var abonne = (from j in musique.ABONNÉS
                          select j).ToList();
            listEdition.Items.Clear();
            foreach (ABONNÉS j in abonne)
            {
                listEdition.Items.Add(j);
            }
        }

        private void chargerListBoxEmprunter()
        {
            var emprunt = (from j in musique.EMPRUNTER
                           select j
                           ).ToList();
            listEmprunt.Items.Clear();
            foreach (EMPRUNTER j in emprunt)
            {
                listEmprunt.Items.Add(j);
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
        private void ajouter_Click(object sender, EventArgs e)
        {
            ABONNÉS a = new ABONNÉS();
            a.NOM_ABONNÉ = "Duthil";
            a.PRÉNOM_ABONNÉ = "Thomas";
            a.LOGIN_ABONNÉ = "tduthil";
            a.PASSWORD_ABONNÉ = "12345";

            musique.ABONNÉS.Add(a);
            musique.SaveChanges();
            chargerListBoxAbonnees();
        }

        private void supp_Click(object sender, EventArgs e)
        {
            if (listEdition.SelectedItem != null)
            {
                ABONNÉS j = (ABONNÉS)listEdition.SelectedItem;
                musique.ABONNÉS.Remove(j);
                musique.SaveChanges();
                chargerListBoxAbonnees();
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

            if (listEdition.SelectedItem != null)
            {
                EMPRUNTER emprunt = new EMPRUNTER();

                ABONNÉS j = (ABONNÉS)listEdition.SelectedItem;
                bool emprunté = false;
                emprunt.CODE_ABONNÉ = j.CODE_ABONNÉ;
                emprunt.DATE_EMPRUNT = DateTime.Now;
                emprunt.CODE_ALBUM = 15;
                var delaiAlbum = from a2 in musique.ALBUMS
                                 where a2.CODE_ALBUM == 15
                                 join p in musique.GENRES
                                 on a2.CODE_GENRE equals p.CODE_GENRE
                                 select p.DÉLAI;
                emprunt.DATE_RETOUR_ATTENDUE = DateTime.Now.AddDays((double)delaiAlbum.First());
                foreach (EMPRUNTER emp in j.EMPRUNTER)
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

        private void ConsulE_Click(object sender, EventArgs e)
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

        }

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

        private void ProlongeTousEmprunts_Click(object sender, EventArgs e)
        {
            var emprunt = from emp in musique.EMPRUNTER
                          join abo in musique.ABONNÉS
                          on emp.CODE_ABONNÉ equals abo.CODE_ABONNÉ
                          where emp.CODE_ABONNÉ == abo.CODE_ABONNÉ
                          select emp;
            foreach(EMPRUNTER emp in emprunt)
            {
                if (!Prolonge(emp) && emp.DATE_RETOUR == null)
                {
                    emp.DATE_RETOUR_ATTENDUE = emp.DATE_RETOUR_ATTENDUE.AddMonths(1);
                }
            }
            MessageBox.Show("Tous les emprunts ont été prolongés.");
            musique.SaveChanges();
            chargerListBoxEmprunter();
        }

        private void ConsulEmpProlongé_Click(object sender, EventArgs e)
        {
            var emprunt = (from j in musique.EMPRUNTER
                           select j
                           ).ToList();
            foreach (EMPRUNTER j in emprunt)
            {
                if (Prolonge(j))
                {
                    MessageBox.Show(j.ToString());
                }

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

        private void chargerListBoxRetards()
        {
            EmpruntsNonRapportes();
            listProlongement.Items.Clear();
            foreach (EMPRUNTER e in empruntsNonRapportes)
            {
                listProlongement.Items.Add(e.ALBUMS.TITRE_ALBUM);
            }
        }

        private void RefreshRetards_Click(object sender, EventArgs e)
        {
            chargerListBoxRetards();
        }

        private void Purgeur_Click(object sender, EventArgs e)
        {
            var abo = from a in musique.ABONNÉS
                      join emp in musique.EMPRUNTER
                      on a.CODE_ABONNÉ equals emp.CODE_ABONNÉ
                      where DateTime.Now.Year - emp.DATE_EMPRUNT.Year >= 1
                      select a;
            foreach (ABONNÉS a in abo)
            {
                //musique.ABONNÉS.Remove(a);
                chargerListBoxPurge();

            }
            //musique.SaveChanges();
            //chargerListBoxAbonnees();
        }

        private void AlbumNonEmp_Click(object sender, EventArgs e)
        {
            var albumNonEmpruntesDepuisUnAn = (from a in musique.ALBUMS
                                               join emp in musique.EMPRUNTER
                                               on a.CODE_ALBUM equals emp.CODE_ALBUM
                                               where DateTime.Now.Year - emp.DATE_EMPRUNT.Year >= 1
                                               where DateTime.Now.Month - emp.DATE_EMPRUNT.Month >= 0
                                               where DateTime.Now.Day - emp.DATE_EMPRUNT.Day >= 0
                                               where DateTime.Now.Hour - emp.DATE_EMPRUNT.Hour >= 0
                                               where DateTime.Now.Minute - emp.DATE_EMPRUNT.Minute >= 0
                                               select a);
            if (albumNonEmpruntesDepuisUnAn.Count() != 0)
            {
                foreach (ALBUMS a in albumNonEmpruntesDepuisUnAn)
                {
                    MessageBox.Show(a.TITRE_ALBUM + " ");
                }
            }
        }

   

        private void button2_Click(object sender, EventArgs e)
        {
            //List<ALBUMS> topAlbums = new List<ALBUMS>();
            var albums = (from j in musique.ALBUMS
                          select j).ToList();
            foreach (ALBUMS a in albums)
            {
                a.cpt = a.EMPRUNTER.Count();
            }
            var topAlbum = (from a3 in musique.ALBUMS
                           join e4 in musique.EMPRUNTER on a3.CODE_ALBUM equals e4.CODE_ALBUM
                           where e4.DATE_EMPRUNT.Year == DateTime.Now.Year
                           orderby e4.CODE_ALBUM descending
                           select  a3).Distinct().ToList();
            int b = 0;
            String list = "";
            foreach (ALBUMS a in topAlbum)
            {
                if (b < 11) { 
                    list = list + a.TITRE_ALBUM + "\n";
                    b++;
                } 
            }
            MessageBox.Show(list);


        }
    }
}
            else
            {
                MessageBox.Show("Aucun Album n'a été emprunté il y a plus d'un ans");
            }

        }
    }
}

