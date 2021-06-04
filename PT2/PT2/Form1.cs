﻿using System;
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
            var joueurs = (from j in musique.EMPRUNTER
                           select j.ALBUMS.TITRE_ALBUM).ToList();
            listBox2.Items.Clear();
            foreach (String j in joueurs)
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
                String titremprunt = (String)listBox2.SelectedItem;
                var emprunt = from a1 in musique.EMPRUNTER
                              where a1.ALBUMS.TITRE_ALBUM == titremprunt
                              select a1;
                musique.EMPRUNTER.Remove(emprunt.First());
                musique.SaveChanges();
                chargerListBoxEmprunter();
            }
        }

        private void emprunt_Click(object sender, EventArgs e)
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

        public void ConsultEmprunt()
        {
            var emprunt = from alb in musiquePT2_MEntities.ALBUMS
                          join e in musiquePT2_MEntities.EMPRUNTER
                          on alb.CODE_ALBUM equals e.CODE_ALBUM
                          where e.CODE_ABONNÉ = musiquePT2_MEntities.ABONNÉS.CODE_ABONNÉ
                          orderby e.DATE_RETOUR_ATTENDUE
                          select alb;
            foreach(EMPRUNTER e in emprunt)
            {
                Console.WriteLine(musiquePT2_MEntities.ALBUMS.TITRE_ALBUM + " " + e.DATE_RETOUR_ATTENDUE);
            }
        }
    }
}

