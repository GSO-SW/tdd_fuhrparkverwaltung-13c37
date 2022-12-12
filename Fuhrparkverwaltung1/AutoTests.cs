using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fuhrparkverwaltung;

namespace FuhrparkverwaltungTests
{
    [TestClass]
    public class AutoTests
    {
        [TestMethod]
        public void Fahren_SteigertKilometerstand()
        {
            //Arrange
            int kilometerstand = 0;
            Auto a = new Auto(kilometerstand);

            int streckeInKilometern = 50;

            //Act
            a.Fahren(streckeInKilometern);

            //Assert
            Assert.AreEqual(50, a.Kilometerstand);
        }

        [TestMethod]
        public void Fahren_NegativKilometerstand()
        {
            //Arrange
            int kilometerstand = 0;
            Auto a = new Auto(kilometerstand);

            int streckeInKilometern = -1;

            //Act
            a.Fahren(streckeInKilometern);

            //Assert
            Assert.AreEqual(0, kilometerstand);
        }

        [TestMethod]
        public void Fahren_VerbauchTankinhalt()
        {
            //Arrange
            int kilometerstand = 0;
            Auto a = new Auto(kilometerstand);

            double verbrauchPro100Km = 5.7;
            double tankInhalt = 10;

            //Act
            a.Fahren(kilometerstand);

            //Assert
            Assert.AreEqual(0, kilometerstand);
        }














    }
}