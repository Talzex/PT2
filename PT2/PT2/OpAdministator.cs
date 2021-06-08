﻿using System;
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
            return j.DATE_EMPRUNT.Month + 1 == j.DATE_RETOUR_ATTENDUE.Month;
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
                      join emp in musique.EMPRUNTER
                      on a.CODE_ABONNÉ equals emp.CODE_ABONNÉ
                      where DateTime.Now.Subtract(emp.DATE_EMPRUNT).TotalDays >= 365//A changer ne fonctionn pas
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

        public List<ALBUMS> AlbumsNonEmprunte()
        {
            albumsnonemprunte = new List<ALBUMS>();
            var albumNonEmpruntesDepuisUnAn = (from a in musique.ALBUMS
                                               join emp in musique.EMPRUNTER
                                               on a.CODE_ALBUM equals emp.CODE_ALBUM
                                               where DateTime.Now.Subtract(emp.DATE_EMPRUNT).TotalDays >= 365//A changer ne fonctionne pas
                                               select a);
            if (albumNonEmpruntesDepuisUnAn.Count() != 0)
            {
                foreach (ALBUMS a in albumNonEmpruntesDepuisUnAn)
                {
                    albumsnonemprunte.Add(a);
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
    }
}
