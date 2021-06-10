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
        PAYS pays;

        public Form1()
        {
            InitializeComponent();
            musique = new MusiquePT2_MEntities();
            chargerComboBoxPays();
        }

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
        
        private void ajouter_Click(object sender, EventArgs e)
        {
            OpAbonne opa = new OpAbonne(nomAbonne, prenomAbonne, loginAbonne, mdpAbonne, ConfmdpAbonne, loginIn, mdpIn, pays, musique);
            opa.ajoutAbonne();
            Refresh();          
        }

        
        private void connexion_Click(object sender, EventArgs e)
        {
            OpAbonne opa = new OpAbonne(nomAbonne, prenomAbonne, loginAbonne, mdpAbonne, ConfmdpAbonne, loginIn, mdpIn, pays, musique);
            opa.connexion();
            Refresh();

        }


        private void textBox_nom_TextChanged(object sender, EventArgs e)
        {
            nomAbonne = textBox_nom.Text.Trim();
        }

        private void textBox_prenom_TextChanged(object sender, EventArgs e)
        {
            prenomAbonne = textBox_prenom.Text.Trim();
        }

        private void textBox_login_TextChanged(object sender, EventArgs e)
        {
            loginAbonne = textBox_login.Text.Trim();
        }

        private void textBox_mdp_TextChanged(object sender, EventArgs e)
        {
            mdpAbonne = textBox_mdp.Text.Trim();
        }

        private void textBox_cmdp_TextChanged(object sender, EventArgs e)
        {
            ConfmdpAbonne = textBox_cmdp.Text.Trim();
        }

        private void textBox_loginIn_TextChanged(object sender, EventArgs e)
        {
            loginIn = textBox_loginIn.Text.Trim();
        }

        private void textBox_mdpIn_TextChanged(object sender, EventArgs e)
        {
            mdpIn = textBox_mdpIn.Text.Trim();
        }

        private void comboBoxPays_SelectedIndexChanged(object sender, EventArgs e)
        {
            pays = (PAYS)comboBoxPays.SelectedItem;
        }
    }
}
  
            

