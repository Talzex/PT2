using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PT2
{
    class OpAdministator
    {
        MusiquePT2_MEntities musique;
        List<EMPRUNTER> empruntsNonRapportes;

        public OpAdministator(MusiquePT2_MEntities musique)
        {
            this.musique = musique;
        }
        private bool Prolonge(EMPRUNTER j)
        {
            return j.DATE_EMPRUNT.Month + 1 == j.DATE_RETOUR_ATTENDUE.Month;
        }

        public List<EMPRUNTER> EmpruntProlonge()
        {
            List<EMPRUNTER> emprunts = new List<EMPRUNTER>();
            var emprunt = (from j in musique.EMPRUNTER
                           select j).ToList();
            foreach (EMPRUNTER j in emprunt)
            {
                if (Prolonge(j))
                {
                    emprunts.Add(j);
                }

            }
            return emprunts;
        }

        public void Purge()
        {
            var abo = from a in musique.ABONNÉS
                      join emp in musique.EMPRUNTER
                      on a.CODE_ABONNÉ equals emp.CODE_ABONNÉ
                      where DateTime.Now.Subtract(emp.DATE_EMPRUNT).TotalDays >= 365
                      select a;
            foreach (ABONNÉS a in abo)
            {

                musique.ABONNÉS.Remove(a);

            }
            musique.SaveChanges();
        }

        public List<EMPRUNTER> RetardEmprunt()
        {
            empruntsNonRapportes = new List<EMPRUNTER>();
            var emprunts = (from j in musique.EMPRUNTER
                            select j).ToList();
            foreach (EMPRUNTER e in emprunts)
            {
                if (e.DATE_RETOUR == null && DateTime.Now.Subtract(e.DATE_RETOUR_ATTENDUE).TotalDays >= 10)
                {
                    empruntsNonRapportes.Add(e);
                }
            }
            return empruntsNonRapportes;
        }
                

    }
}
