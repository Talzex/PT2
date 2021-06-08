using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PT2
{
    class OpUSER
    {
        MusiquePT2_MEntities musique;
        public OpUSER(MusiquePT2_MEntities musique)
        {
            this.musique = musique;
        }

        public void retourner(EMPRUNTER titremprunt)
        {
            var emprunt = from a1 in musique.EMPRUNTER
                          where a1.ALBUMS.TITRE_ALBUM == titremprunt.ALBUMS.TITRE_ALBUM
                          select a1;
            titremprunt.DATE_RETOUR = DateTime.Now;
            musique.SaveChanges();
        }

        public EMPRUNTER emprunte(ALBUMS a, ABONNÉS abo )
        {
            EMPRUNTER emprunt = new EMPRUNTER();

            bool emprunté = false;
            emprunt.CODE_ABONNÉ = abo.CODE_ABONNÉ;
            emprunt.DATE_EMPRUNT = DateTime.Now;
            emprunt.CODE_ALBUM = a.CODE_ALBUM;
            var delaiAlbum = from a2 in musique.ALBUMS
                             where a2.CODE_ALBUM == a.CODE_ALBUM
                             join p in musique.GENRES
                             on a2.CODE_GENRE equals p.CODE_GENRE
                             select p.DÉLAI;
            emprunt.DATE_RETOUR_ATTENDUE = DateTime.Now.AddDays((double)delaiAlbum.First());
            foreach (EMPRUNTER emp in abo.EMPRUNTER)
            {
                if (emprunt.CODE_ALBUM == emp.CODE_ALBUM && !emprunté)
                {
                    emprunté = true;
                }
            }
            if (!emprunté)
            {
                musique.EMPRUNTER.Add(emprunt);
                musique.SaveChanges();
            }
            return emprunt;
        }

        public void prolongation(EMPRUNTER e)
        {
            if (!Prolonge(e) && e.DATE_RETOUR == null)
            {
                e.DATE_RETOUR_ATTENDUE = e.DATE_RETOUR_ATTENDUE.AddMonths(1);
                musique.SaveChanges();
            }
        }

        public void prolongationAll()
        {
            var emprunt = from emp in musique.EMPRUNTER
                          join abo in musique.ABONNÉS
                          on emp.CODE_ABONNÉ equals abo.CODE_ABONNÉ
                          where emp.CODE_ABONNÉ == abo.CODE_ABONNÉ
                          select emp;
            foreach (EMPRUNTER emp in emprunt)
            {
                if (!Prolonge(emp) && emp.DATE_RETOUR == null)
                {
                    emp.DATE_RETOUR_ATTENDUE = emp.DATE_RETOUR_ATTENDUE.AddMonths(1);
                }
            }
            musique.SaveChanges();
        }

        private bool Prolonge(EMPRUNTER j)
        {
            return j.DATE_EMPRUNT.Month + 1 == j.DATE_RETOUR_ATTENDUE.Month;
        }

        public List<ALBUMS> RechercheAlbum(String textBox1)
        {
            List<ALBUMS> albumsR = new List<ALBUMS>();
            var albumR = (from al in musique.ALBUMS
                             where al.TITRE_ALBUM.ToUpper().Contains(textBox1.ToUpper())
                             orderby al.TITRE_ALBUM
                             select al).ToList();
            foreach (ALBUMS al in albumR)
            {
                albumsR.Add(al);
            }
            return albumR;
        }
    }
}
