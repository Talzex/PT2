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
        MusiquePT2_MEntities musique = new MusiquePT2_MEntities();

        public Form1()
        {
            InitializeComponent();
            ConsultEmprunt();
        }

        private void Login_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void ConsultEmprunt()
        {
            var albumemprunt = from alb in musique.ALBUMS
                          join e in musique.EMPRUNTER
                          on alb.CODE_ALBUM equals e.CODE_ALBUM
                          where e.CODE_ABONNÉ == 27
                          orderby e.DATE_RETOUR_ATTENDUE
                          select alb;
            var dateemprunt = from e in musique.EMPRUNTER
                              where e.CODE_ABONNÉ == 27
                              select e;
            MessageBox.Show(albumemprunt.First().TITRE_ALBUM + " " + dateemprunt.First().DATE_RETOUR_ATTENDUE);
        }
    }
}
