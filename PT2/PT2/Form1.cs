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
        MusiquePT2_MEntities bd = new MusiquePT2_MEntities();
        private bool prolonge;

        public Form1()
        {
            InitializeComponent();
            prolonge = true;
        }

        public void Prolongement(EMPRUNTER e) {

            if (prolonge)
            {
                e.DATE_RETOUR_ATTENDUE.AddMonths(1);
                prolonge = false;
            }
        }
         
    }
}
