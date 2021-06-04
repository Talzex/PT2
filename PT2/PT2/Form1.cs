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
        MusiquePT2_MEntities musiquePT2_MEntities = new MusiquePT2_MEntities();

        public Form1()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void ConsultEmprunt()
        {
            var emprunt = from alb in musiquePT2_MEntities.ALBUMS
                          join e in musiquePT2_MEntities.EMPRUNTER
                          on alb.CODE_ALBUM equals e.CODE_ALBUM
                          where e.CODE_ABONNÉ == musiquePT2_MEntities.ABONNÉS.CODE_ABONNÉ
                          orderby e.DATE_RETOUR_ATTENDUE
                          select alb;
            foreach(EMPRUNTER e in emprunt)
            {
                Console.WriteLine(musiquePT2_MEntities.ALBUMS.TITRE_ALBUM + " " + e.DATE_RETOUR_ATTENDUE);
            }
        }

        public void ConsultEmpruntProlongé()
        {
            var empruntProlongé = from e in musiquePT2_MEntities.EMPRUNTER
                                  where e.ALLONGE = true
                                  select e;
            foreach(ALBUMS a in empruntProlongé)
            {
                Console.WriteLine(a.TITRE_ALBUM);
            }
        }
    }
}
