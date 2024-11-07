using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CompteBanqueNS;

namespace BanqueTests
{
    [TestClass]
    public class CompteBancaireTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void DébiterMontantNégatifLèveArgumentOutOfRange()
        {
            // Arrange
            double soldeInitial = 500000;
            var compte = new CompteBancaire("Pr. Abdoulaye Diankha", soldeInitial);
            double montantADébiter = -100; // Montant négatif

            // Act
            compte.Débiter(montantADébiter);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void DébiterMontantSupérieurSoldeLèveArgumentOutOfRange()
        {
            // Arrange
            double soldeInitial = 500000;
            var compte = new CompteBancaire("Pr. Abdoulaye Diankha", soldeInitial);
            double montantADébiter = 600000; // Montant supérieur au solde

            // Act
            compte.Débiter(montantADébiter);
        }

        [TestMethod]
        public void TestDébiterMontantValide()
        {
            double soldeInitial = 500000;
            double montantDébit = 400000;
            double soldeAttendu = 100000;
            var compte = new CompteBancaire("Pr. Abdoulaye Diankha", soldeInitial);

            compte.Débiter(montantDébit);

            double soldeObtenu = compte.Balance;
            Assert.AreEqual(soldeAttendu, soldeObtenu, 0.001, "Débit incorrect");
        }
    }

}