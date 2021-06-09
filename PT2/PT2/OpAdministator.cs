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
        List<EMPRUNTER> empruntsprol;
        List<EMPRUNTER> empruntsNonRapportes;
        List<ALBUMS> albumsnonemprunte;
        List<String> topalbums;

        public OpAdministator(MusiquePT2_MEntities musique)
        {
            this.musique = musique;
        }
        private bool Prolonge(EMPRUNTER j)
        {
            return j.DATE_EMPRUNT.AddDays(j.ALBUMS.GENRES.DÉLAI)!= j.DATE_RETOUR_ATTENDUE;
        }

        public List<EMPRUNTER> EmpruntProlonge()
        {
             empruntsprol = new List<EMPRUNTER>();
            var emprunt = (from j in musique.EMPRUNTER
                           select j).ToList();
            foreach (EMPRUNTER j in emprunt)
            {
                if (Prolonge(j))
                {
                    empruntsprol.Add(j);
                }

            }
            return empruntsprol;
        }

        public void Purge()
        {
            var abo = from a in musique.ABONNÉS
                      select a;
            foreach (ABONNÉS a in abo)
            {
                if (DateTime.Now.Subtract(dernierEmprunt(a)).TotalDays >= 365 && !aDesEmprunts(a))
                {
                    musique.ABONNÉS.Remove(a);
                }

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

        public List<ALBUMS> AlbumsNonEmprunte()
        {
            albumsnonemprunte = new List<ALBUMS>();
            
            var emprunts = (from j in musique.EMPRUNTER
                            select j).ToList();
            var albums  = (from j in musique.ALBUMS
                           select j).ToList();
            foreach (EMPRUNTER e in emprunts)
            {
                foreach(ALBUMS a in albums)
                {
                    if(DateTime.Now.Subtract(e.DATE_EMPRUNT).TotalDays >= 365 || e.DATE_EMPRUNT == null)
                    {
                        albumsnonemprunte.Add(a);
                    }
                }
            }
            return albumsnonemprunte;
        }

        public List<String> TopAlbums()
        {
            topalbums = new List<String>();
            var topAlbum = (from al in musique.ALBUMS
                           join e4 in musique.EMPRUNTER on al.CODE_ALBUM equals e4.CODE_ALBUM
                           where e4.DATE_EMPRUNT.Year == DateTime.Now.Year
                           group al by al.TITRE_ALBUM into g
                           orderby g.Count() descending
                           select new
                           {
                               nb = g.Count(),
                               Name = g.Key
                           }).Take(10);
            if (topAlbum.Count() != 0)
            {
                foreach (var p in topAlbum)
                {
                    topalbums.Add(p.Name);
                }
            }
            return topalbums;
        }

        public DateTime dernierEmprunt(ABONNÉS abo)
        {
            DateTime lastEmprunt = new DateTime();
            var emprunts = (from j in musique.EMPRUNTER
                            where j.CODE_ABONNÉ == abo.CODE_ABONNÉ
                            select j).ToList();
            foreach (EMPRUNTER emp in emprunts)
            {
                if (emp.DATE_EMPRUNT > lastEmprunt)
                {
                    lastEmprunt = emp.DATE_EMPRUNT;
                }
            }
            return lastEmprunt;
        }

        public bool aDesEmprunts(ABONNÉS abo)
        {
            bool emprunts = false;
            foreach (EMPRUNTER emp in abo.EMPRUNTER)
            {
                if (emp.DATE_RETOUR != null)
                {
                    emprunts = true;
                }
            }
            return emprunts;
        }
    }
}
