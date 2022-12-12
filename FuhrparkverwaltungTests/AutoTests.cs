namespace Fuhrparkverwaltung
{
    public class Auto
    {
        private int kilometerstand;
        private double tankInhalt;
        private double tankKapazität;
        private double verbrauchPro100Km;

        public Auto(int kilometerstand, double tankInhalt, double tankKapazität, double verbrauchPro100Km)
        {
            this.kilometerstand = kilometerstand;
            this.tankInhalt = tankInhalt;
            this.tankKapazität = tankKapazität;
            this.verbrauchPro100Km = verbrauchPro100Km;
        }

        public void Fahren(int streckeInKilometern)
        {
            if (streckeInKilometern > 0)
            {
                kilometerstand += streckeInKilometern;
                double verbrauch = streckeInKilometern * verbrauchPro100Km / 100.0;
                tankInhalt -= verbrauch;
            }
        }

        public int Kilometerstand
        {
            get
            {
                return kilometerstand;
            }
        }

        public double TankInhalt
        {
            get
            {
                return tankInhalt;
            }
        }

        public double TankKapazität
        {
            get
            {
                return tankKapazität;
            }
        }

        public double VerbrauchPro100Km
        {
            get
            {
                return verbrauchPro100Km;
            }
        }
    }
}