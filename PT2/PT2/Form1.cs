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

        public Form1()
        {
            InitializeComponent();
            musique = new MusiquePT2_MEntities();
            chargerListBoxAbonnees();
            chargerListBoxEmprunter();
        }

        private void chargerListBoxAbonnees()
        {
            var abonne = (from j in musique.ABONNÉS
                          select j).ToList();
            listBox1.Items.Clear();
            foreach (ABONNÉS j in abonne)
            {
                listBox1.Items.Add(j);
            }
        }

        private void chargerListBoxEmprunter()
        {
            var emprunt = (from j in musique.EMPRUNTER
                           select j
                           ).ToList();
            listBox2.Items.Clear();
            foreach (EMPRUNTER j in emprunt)
            {
                listBox2.Items.Add(j);
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
            if (listBox1.SelectedItem != null)
            {
                ABONNÉS j = (ABONNÉS)listBox1.SelectedItem;
                musique.ABONNÉS.Remove(j);
                musique.SaveChanges();
                chargerListBoxAbonnees();
            }
        }

        private void retourne_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                EMPRUNTER titremprunt = (EMPRUNTER)listBox2.SelectedItem;
                var emprunt = from a1 in musique.EMPRUNTER
                              where a1.ALBUMS.TITRE_ALBUM == titremprunt.ALBUMS.TITRE_ALBUM
                              select a1;
                musique.EMPRUNTER.Remove(emprunt.First());
                musique.SaveChanges();
                chargerListBoxEmprunter();
            }
        }


        private void emprunt_Click(object sender, EventArgs e)
        {
            
            if(listBox1.SelectedItem != null)
            {
                EMPRUNTER emprunt = new EMPRUNTER();

                ABONNÉS j = (ABONNÉS)listBox1.SelectedItem;
                emprunt.CODE_ABONNÉ = j.CODE_ABONNÉ;
                emprunt.DATE_EMPRUNT = DateTime.Now;
                emprunt.CODE_ALBUM = 15;
                var delaiAlbum = from a2 in musique.ALBUMS
                                 where a2.CODE_ALBUM == 15
                                 join p in musique.GENRES
                                 on a2.CODE_GENRE equals p.CODE_GENRE
                                 select p.DÉLAI;
                emprunt.DATE_RETOUR_ATTENDUE = DateTime.Now.AddDays((double)delaiAlbum.First());
                musique.EMPRUNTER.Add(emprunt);
                musique.SaveChanges();
                chargerListBoxEmprunter();
            }
            
        }

        private void ConsulE_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedItem != null)
            {
                ABONNÉS j = (ABONNÉS)listBox1.SelectedItem;
                var albumemprunt = from alb in musique.ALBUMS
                                   join f in musique.EMPRUNTER
                                   on alb.CODE_ALBUM equals f.CODE_ALBUM
                                   where f.CODE_ABONNÉ == j.CODE_ABONNÉ
                                   orderby f.DATE_RETOUR_ATTENDUE
                                   select alb;
                var dateemprunt = from f in musique.EMPRUNTER
                                  where f.CODE_ABONNÉ == j.CODE_ABONNÉ
                                  select f;
                if(dateemprunt.Count() != 0 || albumemprunt.Count() != 0)
                MessageBox.Show(albumemprunt.First().TITRE_ALBUM + dateemprunt.First().DATE_RETOUR_ATTENDUE.ToString());
            }
            
        }

        private void Prolongation_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                EMPRUNTER albumsEmprunte = (EMPRUNTER)listBox2.SelectedItem;

                if (!Prolonge(albumsEmprunte))
                {
                    albumsEmprunte.DATE_RETOUR_ATTENDUE = albumsEmprunte.DATE_RETOUR_ATTENDUE.AddMonths(1);
                    musique.SaveChanges();
                    MessageBox.Show(albumsEmprunte.ALBUMS.TITRE_ALBUM + " " + albumsEmprunte.DATE_RETOUR_ATTENDUE);
                    chargerListBoxEmprunter();
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

        private bool Prolonge(EMPRUNTER j)
        {
            return j.DATE_EMPRUNT.Month + 1 == j.DATE_RETOUR_ATTENDUE.Month;
        }
    }
}

