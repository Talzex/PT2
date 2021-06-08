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
                      where DateTime.Now.Year - emp.DATE_EMPRUNT.Year >= 1
                      where DateTime.Now.Month - emp.DATE_EMPRUNT.Month >= 0
                      where DateTime.Now.Day - emp.DATE_EMPRUNT.Day >= 0
                      where DateTime.Now.Hour - emp.DATE_EMPRUNT.Hour >= 0
                      where DateTime.Now.Minute - emp.DATE_EMPRUNT.Minute >= 0
                      select a;
            foreach (ABONNÉS a in abo)
            {

                musique.ABONNÉS.Remove(a);

            }
            musique.SaveChanges();
        }

    }
}
