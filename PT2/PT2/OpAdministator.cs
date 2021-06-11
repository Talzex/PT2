using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PT2
{
    /*
     * Classe administrateur contenant les différentes méthodes
     */
    class OpAdministator
    {
        MusiquePT2_MEntities musique;
        List<EMPRUNTER> empruntsprol;
        List<EMPRUNTER> empruntsNonRapportes;
        List<ALBUMS> albumsnonemprunte;
        List<String> topalbums;
      
        /*
         * Constructeur OpAdministator 
         */
        public OpAdministator(MusiquePT2_MEntities musique)
        {
            this.musique = musique;
        }

        /*
         * Prolonge() qui permet de prolonger, return la date d'emprunt prolongé
         */
        private bool Prolonge(EMPRUNTER j)
        {
            return j.DATE_EMPRUNT.AddDays(j.ALBUMS.GENRES.DÉLAI)!= j.DATE_RETOUR_ATTENDUE;
        }

        /*
         * EmpruntProlonge() qui permet de connaitre les emprunts qui ont été prolongés, return empruntsprol : liste des emprunts prolongés
         */
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

        /*
         * Purge() permet de supprimer les abonnés n'ayant pas emprunté depuis "n"
         */
        public void Purge(decimal n)
        {
            double date = Convert.ToDouble(n);
            var abo = from a in musique.ABONNÉS
                      select a;
            foreach (ABONNÉS a in abo)
            {
                if (DateTime.Now.Subtract(dernierEmprunt(a)).TotalDays >= date && !aDesEmprunts(a))
                {
                    musique.ABONNÉS.Remove(a);
                }

            }
            musique.SaveChanges();
        }

        /*
         * RetardEmprunt() permet de lister les abonnés ayant des emprunts non rapportés en retard de "n", return empruntsNonRapportes : liste des emprunts en retard
         */
        public List<EMPRUNTER> RetardEmprunt(decimal n)
        {
            double date = Convert.ToDouble(n);
            empruntsNonRapportes = new List<EMPRUNTER>();
            var emprunts = (from j in musique.EMPRUNTER
                            select j).ToList();
            foreach (EMPRUNTER e in emprunts)
            {
                if (e.DATE_RETOUR == null && DateTime.Now.Subtract(e.DATE_RETOUR_ATTENDUE).TotalDays >= date)
                {
                    empruntsNonRapportes.Add(e);
                }
            }
            return empruntsNonRapportes;
        }

        /*
         * AlbumsNonEmprunte() permet de connaitre les albums qui n'ont pas été empruntés depuis "n", return albumsnonemprunte : liste des albums non emprunté
         */
        public List<ALBUMS> AlbumsNonEmprunte(decimal n)
        {
            double date = Convert.ToDouble(n);
            albumsnonemprunte = new List<ALBUMS>();

            var emprunts = (from j in musique.EMPRUNTER
                            orderby j.DATE_EMPRUNT descending
                            select j).ToList();
            var albums = (from j in musique.ALBUMS
                          select j).ToList();
            foreach (EMPRUNTER e in emprunts)
            {
                foreach (ALBUMS a in albums)
                {
                    if ((DateTime.Now.Subtract(e.DATE_EMPRUNT).TotalDays >= 365 && e.CODE_ALBUM.Equals(a.CODE_ALBUM)) || !a.EMPRUNTER.Contains(e) && !albumsnonemprunte.Contains(a))
                    {
                        albumsnonemprunte.Add(a);
                    }
                }
            }
            return albumsnonemprunte;
        }

        /*
         * TopAlbums() permet de connaitre les 10 albums les plus empruntés dans l'année, return topalbums : liste des 10 albums
         */
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
                    topalbums.Add(p.nb.ToString() + " " + p.Name);
                }
            }
            return topalbums;
        }

        /*
         * dernierEmprunt() retourne la date du dernier emprunt 
         */
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

        /*
         * aDesEmprunts() permet de vérifier si un abonné à des emprunts en cours 
         */
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
