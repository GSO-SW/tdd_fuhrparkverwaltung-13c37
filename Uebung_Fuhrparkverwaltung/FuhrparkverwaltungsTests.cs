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
        public void Fahren_NegativerKilometerstand()
        { 
            //Arrange
            int kilometerstand = 0;
            double tankInhalt = 10;
            Auto a = new Auto(kilometerstand, tankInhalt);
            int streckeInKilometern = 50;

            //Act
            a.Fahren(streckeInKilometern);

            //Assert
            Assert.AreEqual(50, a.Kilometerstand);
        }
        [TestMethod]
        public void Fahren_VerbauchtTankInhalt()
        {
            //Arrange
            int kilometerstand = 0;
            double tankInhalt = 10;
            Auto a = new Auto(kilometerstand, tankInhalt);
            int streckeInKilometern = 50;

            //Act
            a.Fahren(streckeInKilometern);

            //Assert
            Assert.AreEqual(10, a.TankInhalt);
        }
    }
}