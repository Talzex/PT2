using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace PT2
{
    /*
     * La classe correspondant à la la page d'accueil.
     */
    public partial class Form1 : Form
    {
        MusiquePT2_MEntities musique;
        String nomAbonne, prenomAbonne, loginAbonne, mdpAbonne, ConfmdpAbonne, loginIn, mdpIn;
        PAYS pays;

        /*
         * Une méthode qui permet d'initialiser les composants de l'interface.
         */
        public Form1()
        {
            InitializeComponent();
            musique = new MusiquePT2_MEntities();
            chargerComboBoxPays();
        }

        /*
         * Une méthode qui permet d'initialiser la liste des pays disponible lors de la création d'un abonné .
         */
        private void chargerComboBoxPays()
        {
            var pays = from p in musique.PAYS
                       orderby p.NOM_PAYS
                       select p;
            foreach (PAYS p in pays)
            {
                comboBoxPays.Items.Add(p);
            }
        }
        
        /*
         * Une méthode permettant d'ajouter un abonné après un click sur le bouton correspondant.
         */
        private void ajouter_Click(object sender, EventArgs e)
        {
            OpAbonne opa = new OpAbonne(nomAbonne, prenomAbonne, loginAbonne, mdpAbonne, ConfmdpAbonne, loginIn, mdpIn, pays, musique);
            opa.ajoutAbonne();
            Refresh();          
        }

        /*
         * Une méthode permettant la connexion d'un abonné sur son compte.
         */
        private void connexion_Click(object sender, EventArgs e)
        {
            OpAbonne opa = new OpAbonne(nomAbonne, prenomAbonne, loginAbonne, mdpAbonne, ConfmdpAbonne, loginIn, mdpIn, pays, musique);
            opa.connexion();
            Refresh();
        }

        /*
         * Une méthode permettant de récupérer ce qui a été entrer dans la zone de texte correspondant au nom du futur abonné.
         */
        private void textBox_nom_TextChanged(object sender, EventArgs e)
        {
            nomAbonne = textBox_nom.Text.Trim();
        }

        /*
         * Une méthode permettant de récupérer ce qui a été entrer dans la zone de texte correspondant au prénom du futur abonné.
         */
        private void textBox_prenom_TextChanged(object sender, EventArgs e)
        {
            prenomAbonne = textBox_prenom.Text.Trim();
        }

        

        /*
         * Une méthode permettant de récupérer ce qui a été entrer dans la zone de texte correspondant au login du futur abonné.
         */
        private void textBox_login_TextChanged(object sender, EventArgs e)
        {
            loginAbonne = textBox_login.Text.Trim();
        }

        

        /*
         * Une méthode permettant de récupérer ce qui a été entrer dans la zone de texte correspondant au mot de passe du futur abonné.
         */
        private void textBox_mdp_TextChanged(object sender, EventArgs e)
        {
            mdpAbonne = textBox_mdp.Text.Trim();
        }

        

        private void oeil1_Click(object sender, EventArgs e)
        {
            if (textBox_mdp.UseSystemPasswordChar)
            {
                textBox_mdp.UseSystemPasswordChar = false;
            }
            else
            {
                textBox_mdp.UseSystemPasswordChar = true;
            }
        }

        /*
         * Une méthode permettant de récupérer ce qui a été entrer dans la zone de texte correspondant à la confirmation du mot de passe du futur abonné.
         */
        private void textBox_cmdp_TextChanged(object sender, EventArgs e)
        {
            ConfmdpAbonne = textBox_cmdp.Text.Trim();
        }

        private void oeil2_Click(object sender, EventArgs e)
        {
            if (textBox_cmdp.UseSystemPasswordChar)
            {
                textBox_cmdp.UseSystemPasswordChar = false;
            }
            else
            {
                textBox_cmdp.UseSystemPasswordChar = true;
            }
        }

        /*
         * Une méthode permettant de récupérer ce qui a été entrer dans la zone de texte correspondant au login d'un abonné qui souhaite se connecter.
         */
        private void textBox_loginIn_TextChanged(object sender, EventArgs e)
        {
            loginIn = textBox_loginIn.Text.Trim();
        }

        /*
         * Une méthode permettant de récupérer ce qui a été entrer dans la zone de texte correspondant au mot de passe d'un abonné qui souhaite se connecter.
         */
        private void textBox_mdpIn_TextChanged(object sender, EventArgs e)
        {
            mdpIn = textBox_mdpIn.Text.Trim();
        }

        private void oeil3_Click(object sender, EventArgs e)
        {
            if (textBox_mdpIn.UseSystemPasswordChar)
            {
                textBox_mdpIn.UseSystemPasswordChar = false;
            }
            else
            {
                textBox_mdpIn.UseSystemPasswordChar = true;
            }
        }
        /*
         * Une méthode permettant de récupérer ce qui a été sélectionner par l'utilisateur lors de la création de son compte correspondant à son pays.
         */
        private void comboBoxPays_SelectedIndexChanged(object sender, EventArgs e)
        {
            pays = (PAYS)comboBoxPays.SelectedItem;
        }
    }
}
  
            

