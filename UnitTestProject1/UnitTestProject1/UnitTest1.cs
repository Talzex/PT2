using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Collections.Generic;
using PT2;
using System.Data.Entity;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        MusiquePT2_MEntities musique = new MusiquePT2_MEntities();
        PT2.OpAbonne opu;
        /*J'ai tenté de supprimer mes emprunts et mes abonnées mais malgré l'aide  d'un professeur je n'ai pas réussi à les supprimer */
        [TestMethod]
        public void InscriptionEmprunte()
        {
            OpUSER user = new OpUSER(musique);
            Outils outils = new Outils();
            var selectnewAbo =( from abo in musique.ABONNÉS
                               where abo.LOGIN_ABONNÉ == "testus1"
                               select abo).ToList();
            if(selectnewAbo.Count() == 0)
            {
                opu = new OpAbonne("TESTUS1", "TESTUS1", "testus1", "123456789", "123456789", "", "", musique);
                opu.ajoutAbonne();
                musique.SaveChanges();
                
            }
            var selectcréation = (from abo in musique.ABONNÉS
                                  where abo.LOGIN_ABONNÉ == "testus1"
                                  select abo).ToList();
            var selectcodeAbo = (from abo in musique.ABONNÉS
                                 where abo.LOGIN_ABONNÉ == "testus1"
                                 select abo.CODE_ABONNÉ).ToList();
            Assert.IsTrue(1 == selectcréation.Count());
            
            var selectEmprunt = (from al in musique.ALBUMS
                                 where al.TITRE_ALBUM == "Bach J-C: Sinfonien"
                                 select al).ToList();
            if(selectEmprunt.Count() != 0)
            {
                user.emprunte(selectEmprunt.First(), selectcréation.First());
                var selectEmpruntAbo = (from emp in musique.EMPRUNTER
                                        where emp.CODE_ABONNÉ == selectcodeAbo.FirstOrDefault()
                                        select emp).ToList();
                Assert.IsTrue(selectEmpruntAbo.First().DATE_EMPRUNT != null);
                //outils.suppAbo(selectcréation.First());
            }

        }
        
        [TestMethod]
        public void VoirEmprunt()
        {
            OpUSER user = new OpUSER(musique);
            Outils outils = new Outils();
            List<EMPRUNTER> emprunt = new List<EMPRUNTER>();
            var selectnewAbo = (from abo in musique.ABONNÉS
                                where abo.LOGIN_ABONNÉ == "testus2"
                                select abo).ToList();
            if (selectnewAbo.Count() == 0)
            {
                opu = new OpAbonne("TESTUS2", "TESTUS2", "testus2", "123", "123", "", "", musique);
                opu.ajoutAbonne();

            }
            var selectcréation = (from abo in musique.ABONNÉS
                                  where abo.LOGIN_ABONNÉ == "testus2"
                                  select abo).ToList();
            var selectEmprunt = (from al in musique.ALBUMS
                                 where al.TITRE_ALBUM == "Bach J-C: Sinfonien"
                                 select al).ToList();
            var selectEmprunt2 = (from al in musique.ALBUMS
                                 where al.TITRE_ALBUM == "Bach: Symphonien"
                                  select al).ToList();
            
            if (selectEmprunt.Count() != 0 && selectEmprunt2.Count() != 0)
            {
                emprunt.Add(user.emprunte(selectEmprunt.First(), selectcréation.First()));
                emprunt.Add(user.emprunte(selectEmprunt2.First(), selectcréation.First()));
                var selectcodeAbo = (from abo in musique.ABONNÉS
                                     where abo.LOGIN_ABONNÉ == "testus2"
                                     select abo.CODE_ABONNÉ).ToList();
                var selectEmpruntAbo = (from emp in musique.EMPRUNTER
                                        where emp.CODE_ABONNÉ == selectcodeAbo.FirstOrDefault()
                                        select emp).ToList();
                Assert.IsTrue(emprunt[0].CODE_ALBUM.Equals(selectEmpruntAbo.First().CODE_ALBUM));
                Assert.IsTrue(emprunt[1].CODE_ALBUM.Equals(selectEmprunt2.First().CODE_ALBUM));

                /*foreach(EMPRUNTER e in selectEmpruntAbo)
                {
                    outils.suppEmprunt(e, selectcréation.First());
                }
                outils.suppAbo(selectcréation.First());*/
            }
        }
    }
}
