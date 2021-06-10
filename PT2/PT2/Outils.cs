using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PT2
{
    public class Outils
    {
        MusiquePT2_MEntities musique = new MusiquePT2_MEntities();
        public void suppAbo(ABONNÉS abo)
        {
            musique.ABONNÉS.Remove(abo);
            musique.SaveChanges();
        }

        public void suppEmprunt(EMPRUNTER emp)
        {
            musique.EMPRUNTER.Remove(emp);
            musique.SaveChanges();
        }

    }
}
