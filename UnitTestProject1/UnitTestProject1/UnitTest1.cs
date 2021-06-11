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
            var selectPays = (from pays in musique.PAYS
                              where pays.CODE_PAYS == 1
                              select pays);
            OpUSER user = new OpUSER(musique);
            Outils outils = new Outils();
            var selectnewAbo =( from abo in musique.ABONNÉS
                               where abo.LOGIN_ABONNÉ == "testus1"
                               select abo).ToList();
            if(selectnewAbo.Count() == 0)
            {
                opu = new OpAbonne("TESTUS1", "TESTUS1", "testus1", "123456789", "123456789", "", "",selectPays.First(), musique);
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
            }

        }
        
        [TestMethod]
        public void VoirEmprunt()
        {
            var selectPays = (from pays in musique.PAYS
                              where pays.CODE_PAYS == 1
                              select pays);
            OpUSER user = new OpUSER(musique);
            Outils outils = new Outils();
            bool emprunt1;
            bool emprunt2;
            var selectnewAbo = (from abo in musique.ABONNÉS
                                where abo.LOGIN_ABONNÉ == "testus2"
                                select abo).ToList();
            if (selectnewAbo.Count() == 0)
            {
                opu = new OpAbonne("TESTUS2", "TESTUS2", "testus2", "123", "123", "", "", selectPays.First(),musique);
                opu.ajoutAbonne();

            }
            var selectcréation = (from abo in musique.ABONNÉS
                                  where abo.LOGIN_ABONNÉ == "testus2"
                                  select abo).ToList();
            var selectEmprunt = (from al in musique.ALBUMS
                                 where al.TITRE_ALBUM == "Bach, CPE: Concertos pour violoncelle"
                                 select al).ToList();
            var selectEmprunt2 = (from al in musique.ALBUMS
                                 where al.TITRE_ALBUM == "Bach: 6 Sonaten für Violine und Cembalo"
                                  select al).ToList();
            
            if (selectEmprunt.Count() != 0 && selectEmprunt2.Count() != 0)
            {
                emprunt1 = user.emprunte(selectEmprunt.First(), selectcréation.First());
                emprunt2 = user.emprunte(selectEmprunt2.First(), selectcréation.First());
                var selectcodeAbo = (from abo in musique.ABONNÉS
                                     where abo.LOGIN_ABONNÉ == "testus2"
                                     select abo.CODE_ABONNÉ).ToList();
                var selectEmpruntAbo = (from emp in musique.EMPRUNTER
                                        where emp.CODE_ABONNÉ == selectcodeAbo.FirstOrDefault()
                                        select emp).ToList();
                Assert.IsTrue(emprunt1);
                Assert.IsTrue(emprunt2);

            }
        }
    }
}
