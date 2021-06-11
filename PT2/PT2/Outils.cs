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
            musique.ABONNÉS.Remove(abo);
            musique.SaveChanges();
        }

        public void suppEmprunt(EMPRUNTER emp)
        {
            MusiquePT2_MEntities musique = new MusiquePT2_MEntities();
            musique.EMPRUNTER.Remove(emp);
            musique.SaveChanges();
        }

    }
}
