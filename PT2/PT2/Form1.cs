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

        public Form1()
        {
            InitializeComponent();
        }


        /*
         * CODE_ABONNÉ pour l'abonné qui souhaite prolonger
         * CODE_ALBUM sur l'album qu'il souhaite prolonger
         * --> vérifier si son CODE_ALBUM est bien dans sa liste de ses emprunts 
         * --> Si l'action de répète vérifier si il y a déjà eu modification du temps sur le CODE_ALBUM 
         * DATE_RETOUR_ATTENDUE qui stocke la date du rendu
         * Ajouter 1 mois à sa date
         * Changer l'état de l'empreint à "prolongé"
         */

        // Emprunts d'un abonné "ca"
        //var emprunts = from e in bd.EMPRUNTER
        //               join a in bd.ABONNÉS
        //               on e.CODE_ABONNÉ equals a.CODE_ABONNÉ
        //               where e.CODE_ABONNÉ == ca
        //               select e;




        public void Prolongement(EMPRUNTER e) {

            if (!e.PROLONGE)
            {
                e.DATE_RETOUR_ATTENDUE.AddMonths(1);
                e.PROLONGE = true;
            }
        }

        public int Get_Code_Album(EMPRUNTER e){
            return e.CODE_ALBUM;
        }
         
    }
}
