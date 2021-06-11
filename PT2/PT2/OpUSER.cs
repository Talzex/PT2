using System;
using System.Collections.Generic;
using System.Linq;

namespace PT2
{
    /*
     * La classe correspondant aux opérations effectué par un utilisateur.
     */
    class OpUSER
    {
        MusiquePT2_MEntities musique;

        /*
         * Le constructeur d'un utilisateur.
         */
        public OpUSER(MusiquePT2_MEntities musique)
        {
            this.musique = musique;
        }

        /*
         * Une méthode permettant de retourner un album emprunté.
         */
        public void retourner(EMPRUNTER titremprunt)
        {
            var emprunt = from a1 in musique.EMPRUNTER
                          where a1.ALBUMS.TITRE_ALBUM == titremprunt.ALBUMS.TITRE_ALBUM
                          select a1;
            titremprunt.DATE_RETOUR = DateTime.Now;
            musique.SaveChanges();
        }

        /*
         * Une méthode permettant d'emprunter un album.
         */
        public bool emprunte(ALBUMS a, ABONNÉS abo )
        {
            EMPRUNTER emprunt = new EMPRUNTER();
            EMPRUNTER empruntRendu = null;
            bool emprunté = false;
            bool rendu = false;
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
                    if (emp.DATE_RETOUR != null)
                    {
                        rendu = true;
                        empruntRendu = emp;
                    }
                    else
                    {
                        emprunté = true;
                    }
                    
                }
            }
            if (rendu)
            {
                musique.EMPRUNTER.Remove(empruntRendu);
                musique.SaveChanges();
            }
            if (!emprunté)
            {
                musique.EMPRUNTER.Add(emprunt);
                musique.SaveChanges();
            }
            return emprunté;
        }

        /*
         * Une méthode permettant de prolongé un emprunt.
         */
        public bool prolongation(EMPRUNTER e)
        {
            if (!Prolonge(e) && e.DATE_RETOUR == null)
            {
                e.DATE_RETOUR_ATTENDUE = e.DATE_RETOUR_ATTENDUE.AddMonths(1);
                musique.SaveChanges();
                return true;
            }
            return false;
        }

        /*
         * Une méthode permettant de prolongé tous les emprunts.
         */
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

        /*
         * Une méthode permettant de déterminer si un emprunt à déjà été prolongé.
         */
        public bool Prolonge(EMPRUNTER j)
        {
            return j.DATE_EMPRUNT.Month + 1 == j.DATE_RETOUR_ATTENDUE.Month;
        }

        /*
         * Une méthode retournant une liste d'album correspondant à la recherche effectuée.
         */
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

        /*
         * Une méthode retournant une liste d'album suggérés en fonction des emprunts précédent de l'utilisateur.
         */
        public List<ALBUMS> Suggestions(ABONNÉS abo)
        {
            List<ALBUMS> suggestions = new List<ALBUMS>();
            List<String> ng = new List<String>();
            List<String> ne = new List<String>();
            List<int> aa = new List<int>();
            var albemp = (from emp in musique.EMPRUNTER
                         where emp.CODE_ABONNÉ == abo.CODE_ABONNÉ
                         select emp).ToList();

            if (albemp.Count() > 0)
            {
                
                foreach (EMPRUNTER e in albemp)
                {
                    var genre = from alb in musique.ALBUMS
                                where e.CODE_ALBUM == alb.CODE_ALBUM
                                select alb.CODE_GENRE;
                    foreach (int g in genre)
                    {
                        var nomGenre = from gen in musique.GENRES
                                       where gen.CODE_GENRE == g
                                       select gen.LIBELLÉ_GENRE;
                        foreach (String s in nomGenre)
                        {
                            ng.Add(s);
                        }
                    }
                    var editeur = from alb in musique.ALBUMS
                                  where e.CODE_ALBUM == alb.CODE_ALBUM
                                  select alb.CODE_EDITEUR;
                    foreach (int edi in editeur)
                    {
                        var nomEditeur = from nomEdi in musique.EDITEURS
                                         where nomEdi.CODE_EDITEUR == edi
                                         select nomEdi.NOM_EDITEUR;
                        foreach (String s in nomEditeur)
                        {
                            ne.Add(s);
                        }
                    }
                    var annee = from an in musique.ALBUMS
                                where e.CODE_ALBUM == an.CODE_ALBUM
                                select an.ANNÉE_ALBUM;
                    foreach (int an in annee)
                    {
                        aa.Add(an);
                    }
                }
                for (int i = 0; i < aa.Count(); i++)
                {
                    String nomGenre = ng.ElementAt(i);
                    String nomEdit = ne.ElementAt(i);
                    int anneeAlb = aa.ElementAt(i);

                    var sug = (from a in musique.ALBUMS
                               join e in musique.EDITEURS
                               on a.CODE_EDITEUR equals e.CODE_EDITEUR
                               join g in musique.GENRES
                               on a.CODE_GENRE equals g.CODE_GENRE
                               where g.LIBELLÉ_GENRE == nomGenre
                               where e.NOM_EDITEUR == nomEdit
                               select a);
                    foreach (ALBUMS a in sug)
                    {
                        bool emprunté = false;
                        foreach (EMPRUNTER emp in albemp)
                        {
                            if (emp.CODE_ALBUM.Equals(a.CODE_ALBUM))
                            {
                                emprunté = true;
                            }
                        }
                        if (!emprunté && !suggestions.Contains(a))
                        {
                            suggestions.Add(a);
                            i++;
                        }
                    }
                }
            }
            else
            {
                OpAdministator opa = new OpAdministator(musique);
                var albums = (from j in musique.ALBUMS
                              select j).ToList();
                foreach (String name in opa.TopAlbums())
                {
                    foreach (ALBUMS a in albums)
                    {
                        if (name.Equals(a.TITRE_ALBUM))
                        {
                            suggestions.Add(a);
                        }
                    }
                }
            }
            return suggestions;
        }
    }
}
