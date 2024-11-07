using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CompteBanqueNS;

namespace BanqueTests
{
    [TestClass]
    public class CompteBancaireTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            double soldeInitial = 500000;
            double montantDébit = 400000;
            double soldeAttendu = 100000;
            var compte = new CompteBancaire("Pr. Abdoulaye Diankha", soldeInitial);

            compte.Débiter(montantDébit);

            double soldeObtenu = compte.Balance;
            Assert.AreEqual(soldeAttendu, soldeObtenu, 0.001, "debit incorrect");
        }
    }
}
