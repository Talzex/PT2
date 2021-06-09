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
    class OpAbonne
    {
        MusiquePT2_MEntities musique;

        String nomAbonne;
        String prenomAbonne;
        String loginAbonne;
        String mdpAbonne;
        String ConfmdpAbonne;
        String loginIn;
        String mdpIn;

        public OpAbonne(String nomAbonne, String prenomAbonne, String loginAbonne, String mdpAbonne, String ConfmdpAbonne, String loginIn, String mdpIn, MusiquePT2_MEntities musique)
        {
            this.nomAbonne = nomAbonne;
            this.prenomAbonne = prenomAbonne;
            this.loginAbonne = loginAbonne;
            this.mdpAbonne = mdpAbonne;
            this.ConfmdpAbonne = ConfmdpAbonne;
            this.loginIn = loginIn;
            this.mdpIn = mdpIn;
            this.musique = musique;
        }

        public void ajoutAbonne()
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
                    if (mdpAbonne.Equals(ab.PASSWORD_ABONNÉ.Trim()) && unique)
                    {
                        unique = false;
                        MessageBox.Show("erreur : ce mot de passe existe déjà, il appartient à " + ab.NOM_ABONNÉ + " " + ab.PRÉNOM_ABONNÉ);
                    }
                    else if (loginAbonne.Equals(ab.LOGIN_ABONNÉ.Trim()) && unique)
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
        }

        public void connexion()
        {
            bool trouve = false;
            var abonne = (from j in musique.ABONNÉS
                          select j).ToList();
            if (loginIn != null && mdpIn != null && loginIn != "" && mdpIn != "")
            {
                if (loginIn.Equals("admin") && mdpIn.Equals("admin"))
                {
                    trouve = true;
                    Administrator admin = new Administrator();
                    admin.Show();
                }
                else
                {
                    foreach (ABONNÉS ab in abonne)
                    {
                        Console.WriteLine(ab.PASSWORD_ABONNÉ + ab.LOGIN_ABONNÉ);
                        if (loginIn.Equals(ab.LOGIN_ABONNÉ.Trim()) && mdpIn.Equals(ab.PASSWORD_ABONNÉ.Trim()) && !trouve)
                        {
                            trouve = true;
                            USER Iuser = new USER(ab.CODE_ABONNÉ);
                            Iuser.Show();
                        }
                    }
                    if (!trouve)
                    {
                        MessageBox.Show("erreur : login ou mot de passe incorrects");
                    }
                }

            }
            else
            {
                MessageBox.Show("erreur : champs non remplis, veuillez remplir tous les champs");
            }
        }
    }
}
