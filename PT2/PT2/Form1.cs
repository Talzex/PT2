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
            //chargerListBoxAbonnees();

            //chargerListBoxRetards();
            //ConsultEmprunt();
        }

        /*private void chargerListBoxAbonnees()
        {
            var abonne = (from j in musique.ABONNÉS
                          select j).ToList();
            listEdition.Items.Clear();
            foreach (ABONNÉS j in abonne)
            {
                listEdition.Items.Add(j);
            }
        }*/

        

        
        private void ajouter_Click(object sender, EventArgs e)
        {
            bool unique = true;
            var abonne = (from j in musique.ABONNÉS
                          select j).ToList();
            ABONNÉS a = new ABONNÉS(); 
            if (nomAbonne != null && prenomAbonne != null && loginAbonne != null && mdpAbonne != null && ConfmdpAbonne != null && 
                nomAbonne != "" && prenomAbonne != "" && loginAbonne != "" && mdpAbonne != "" && ConfmdpAbonne != "")
            {
                foreach (ABONNÉS ab in abonne)
                {
                    if (mdpAbonne.Equals(ab.PASSWORD_ABONNÉ))
                    {
                        unique = false;
                        MessageBox.Show("erreur : ce mot de passe existe déjà, il appartient à " + ab.NOM_ABONNÉ + " " +ab.PRÉNOM_ABONNÉ);
                    }
                    else if (loginAbonne.Equals(ab.LOGIN_ABONNÉ))
                    {
                        unique = false;
                        MessageBox.Show("erreur : ce login existe déjà");
                    }
                }
                if (unique)
                {
                    a.NOM_ABONNÉ = nomAbonne;
                    a.PRÉNOM_ABONNÉ = prenomAbonne;
                    a.LOGIN_ABONNÉ = loginAbonne;
                    if (mdpAbonne.Equals(ConfmdpAbonne))
                    {
                        a.PASSWORD_ABONNÉ = mdpAbonne;
                        musique.ABONNÉS.Add(a);
                        musique.SaveChanges();
                        MessageBox.Show("Inscription réussie");
                    }
                    else
                    {
                        MessageBox.Show("erreur : mot de passe non confirmé");
                    }
                }
            }
            else
            {
                MessageBox.Show("erreur : champs non remplis, veuillez remplir tous les champs");
            }
            Refresh();          
        }
        private void connexion_Click(object sender, EventArgs e)
        {
            bool trouve = false;
            var abonne = (from j in musique.ABONNÉS
                          select j).ToList();
            if (loginIn != null && mdpIn != null && loginIn != "" && mdpIn != "")
            {
                foreach (ABONNÉS ab in abonne)
                {
                    if (ab.LOGIN_ABONNÉ.Equals(loginIn) && ab.PASSWORD_ABONNÉ.Equals(mdpIn) && !trouve)
                    {
                        trouve = true;
                        USER Iuser = new USER(ab);
                        Iuser.Show();
                    }
                }
                if (!trouve)
                {
                    MessageBox.Show("erreur : login ou mot de passe incorrects");
                }
            }
            else
            {
                MessageBox.Show("erreur : champs non remplis, veuillez remplir tous les champs");
            }
            
        }
        /*private void supp_Click(object sender, EventArgs e)
        {
            if (listEdition.SelectedItem != null)
            {
                ABONNÉS j = (ABONNÉS)listEdition.SelectedItem;
                musique.ABONNÉS.Remove(j);
                musique.SaveChanges();
                chargerListBoxAbonnees();
            }
        }*/

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
        }*/
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




        /*private void chargerListBoxRetards()
        {
            EmpruntsNonRapportes();
            listProlongement.Items.Clear();
            foreach (EMPRUNTER e in empruntsNonRapportes)
            {
                listProlongement.Items.Add(e.ALBUMS.TITRE_ALBUM);
            }
        }*/

        /*private void RefreshRetards_Click(object sender, EventArgs e)
        {
            chargerListBoxRetards();
        }*/

        /*private bool Prolonge(EMPRUNTER j)
        {
            return j.DATE_EMPRUNT.Month + 1 == j.DATE_RETOUR_ATTENDUE.Month;
        }*/

        /*private void Purgeur_Click(object sender, EventArgs e)
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
            else
            {
                MessageBox.Show("Aucun Album n'a été emprunté il y a plus d'un ans");
            }

        }

        private void TopAlbumEmp_Click(object sender, EventArgs e)
        {
            var topAlbum = from al in musique.ALBUMS
                           join e4 in musique.EMPRUNTER on al.CODE_ALBUM equals e4.CODE_ALBUM
                           where e4.DATE_EMPRUNT.Year == DateTime.Now.Year
                           group al by al.TITRE_ALBUM into g
                           orderby g.Count() descending
                           select new
                           {
                               nb = g.Count(),
                               Name = g.Key
                           };
            if (topAlbum.Count() != 0)
            {
                foreach (var p in topAlbum)
                {
                    MessageBox.Show(p.nb + " " + p.Name);
                }
            }
            else
            {
                MessageBox.Show("Aucun Album emprunté durant l'année : " + DateTime.Now.Year);
            }

        }

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
        }
    

        public void chargerListAbos()
        {
            var abonne = (from j in musique.ABONNÉS
                          select j).ToList();
            ListAbo.Items.Clear();
            if (abonne != null)
            {
                foreach (ABONNÉS j in abonne)
                {
                    ListAbo.Items.Add(j);
                }
            } else { 
                    MessageBox.Show("Il n'y a aucun abonnés");
                }
            }

        private void button2_Click(object sender, EventArgs e)
        {
            chargerListAbos();
        }

  
    }
}
  
            

