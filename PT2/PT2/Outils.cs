using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PT2
{
    public class Outils
    {
        public void suppAbo(ABONNÉS abo)
        {
            MusiquePT2_MEntities musique = new MusiquePT2_MEntities();
            
            if(abo.EMPRUNTER.Count() != 0)
            {
                foreach(EMPRUNTER e in abo.EMPRUNTER)
                {
                    suppEmprunt(e,abo);
                }
            }

            musique.Database.ExecuteSqlCommand("DELETE FROM ABONNÉS WHERE CODE_ABONNÉ=" + abo.CODE_ABONNÉ);
            musique.SaveChanges();
        }

        public void suppEmprunt(EMPRUNTER emp, ABONNÉS abo)
        {
            MusiquePT2_MEntities musique = new MusiquePT2_MEntities();
            abo.EMPRUNTER.Remove(emp);
            musique.EMPRUNTER.Remove(emp);
            musique.SaveChanges();
        }

    }
}
