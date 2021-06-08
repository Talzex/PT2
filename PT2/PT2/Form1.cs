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
        
        String nomAbonne;
        String prenomAbonne;
        String loginAbonne;
        String mdpAbonne;
        String ConfmdpAbonne;
        String loginIn;
        String mdpIn;

        public Form1()
        {
            InitializeComponent();
            musique = new MusiquePT2_MEntities();
        }
        
        private void ajouter_Click(object sender, EventArgs e)
        {
            OpAbonne opa = new OpAbonne(nomAbonne, prenomAbonne, loginAbonne, mdpAbonne, ConfmdpAbonne, loginIn, mdpIn, musique);
            opa.ajoutAbonne();
            Refresh();          
        }

        
        private void connexion_Click(object sender, EventArgs e)
        {
            OpAbonne opa = new OpAbonne(nomAbonne, prenomAbonne, loginAbonne, mdpAbonne, ConfmdpAbonne, loginIn, mdpIn, musique);
            opa.connexion();
            Refresh();

        }


        private void textBox_nom_TextChanged(object sender, EventArgs e)
        {
            nomAbonne = textBox_nom.Text;
        }

        private void textBox_prenom_TextChanged(object sender, EventArgs e)
        {
            prenomAbonne = textBox_prenom.Text;
        }

        private void textBox_login_TextChanged(object sender, EventArgs e)
        {
            loginAbonne = textBox_login.Text;
        }

        private void textBox_mdp_TextChanged(object sender, EventArgs e)
        {
            mdpAbonne = textBox_mdp.Text;
        }

        private void textBox_cmdp_TextChanged(object sender, EventArgs e)
        {
            ConfmdpAbonne = textBox_cmdp.Text;
        }

        private void textBox_loginIn_TextChanged(object sender, EventArgs e)
        {
            loginIn = textBox_loginIn.Text;
        }

        private void textBox_mdpIn_TextChanged(object sender, EventArgs e)
        {
            mdpIn = textBox_mdpIn.Text;
        }

        /*
        private void Suggestions(ABONNÉS abo)
        {
            List<String> ng = new List<String>();
            List<String> ne = new List<String>();
            List<int> aa = new List<int>();

            var albemp = from emp in musique.EMPRUNTER
                         where emp.CODE_ABONNÉ == abo.CODE_ABONNÉ
                         select emp;

            if(albemp != null)
            {
                foreach (EMPRUNTER e in albemp)
                {
                    var genre = from alb in musique.ALBUMS
                                where e.CODE_ALBUM == alb.CODE_ALBUM
                                select alb.CODE_GENRE;
                    foreach (int g in genre)
                    {
                        var nomGenre = from gen in musique.GENRES
                                       where gen.CODE_GENRE == g
                                       select gen.LIBELLÉ_GENRE;
                        foreach (String s in nomGenre)
                        {
                            ng.Add(s);
                        }
                    }

                    var editeur = from alb in musique.ALBUMS
                                  where e.CODE_ALBUM == alb.CODE_ALBUM
                                  select alb.CODE_EDITEUR;
                    foreach (int edi in editeur)
                    {
                        var nomEditeur = from nomEdi in musique.EDITEURS
                                         where nomEdi.CODE_EDITEUR == edi
                                         select nomEdi.NOM_EDITEUR;
                        foreach (String s in nomEditeur)
                        {
                            ne.Add(s);
                        }
                    }

                    var annee = from an in musique.ALBUMS
                                where e.CODE_ALBUM == an.CODE_ALBUM
                                select an.ANNÉE_ALBUM;
                    foreach (int an in annee)
                    {
                        aa.Add(an);
                    }
                }
                for (int i = 0; i < aa.Count(); i++)
                {
                    String nomGenre = ng.ElementAt(i);
                    String nomEdit = ne.ElementAt(i);
                    int anneeAlb = aa.ElementAt(i);

                    var sug = (from a in musique.ALBUMS
                               join e in musique.EDITEURS
                               on a.CODE_EDITEUR equals e.CODE_EDITEUR
                               join g in musique.GENRES
                               on a.CODE_GENRE equals g.CODE_GENRE
                               where g.LIBELLÉ_GENRE == nomGenre
                               where e.NOM_EDITEUR == nomEdit
                               where a.ANNÉE_ALBUM == anneeAlb
                               select a);

                    foreach (ALBUMS a in sug)
                    {
                        listSuggestions.Items.Add(a.TITRE_ALBUM.ToString() + " " + a.EDITEURS.NOM_EDITEUR.ToString() + " " + a.GENRES.LIBELLÉ_GENRE.ToString());
                        i++;
                    }

                }
            } else
            {
                //  Appeller méthode TOP10
            }
            
        }

        private void sug_Click_1(object sender, EventArgs e)
        {
            listSuggestions.Items.Clear();
            if(listEdition.SelectedItem != null)
            {
                ABONNÉS abo = (ABONNÉS)listEdition.SelectedItem;
                Suggestions(abo);
            }
        }*/
    }
}
  
            

