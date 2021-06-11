using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
namespace PT2
{
    /*
     * La classe correspondant aux opérations effectué par l'abonné.
     */
    public class OpAbonne
    {
        MusiquePT2_MEntities musique;
        string nomAbonne, prenomAbonne, loginAbonne, mdpAbonne, ConfmdpAbonne, loginIn, mdpIn;
        PAYS pays;

        /*
         * Constructeur d'un abonné avec les informations données lors de son inscription.
         */
        public OpAbonne(string nomAbonne, string prenomAbonne, string loginAbonne, string mdpAbonne, string ConfmdpAbonne, string loginIn, string mdpIn, PAYS pays, MusiquePT2_MEntities musique)
        {
            this.nomAbonne = nomAbonne;
            this.prenomAbonne = prenomAbonne;
            this.loginAbonne = loginAbonne;
            this.mdpAbonne = mdpAbonne;
            this.ConfmdpAbonne = ConfmdpAbonne;
            this.loginIn = loginIn;
            this.mdpIn = mdpIn;
            this.pays = pays;
            this.musique = musique;
        }

        /*
         * Une méthode permettant d'ajouter l'abonné dans la base de données puis d'envoyer un message de confirmation si l'opération s'est effectuée.
         */
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
                    if (loginAbonne.Equals(ab.LOGIN_ABONNÉ.Trim()) && unique)
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
                    if (pays != null)
                    {
                        a.PAYS = pays;
                    }
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

        /*
         * Une méthode permettant la connection d'un abonné à l'application.
         */
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
