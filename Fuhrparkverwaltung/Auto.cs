namespace Fuhrparkverwaltung
{
    public class Auto
    {
        private int kilometerstand;
        private double tankInhalt;
        private double verbrauchPro100Km;

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

        public Auto(int kilometerstand)
        {
            this.kilometerstand = kilometerstand;
        }

        public Auto(int kilometerstand, double tankInhalt, double verbauchPro100Km) :this(kilometerstand)
        {
            this.tankInhalt = tankInhalt;
        }


        public void Fahren(int streckeInKilometern)
        {
            if (streckeInKilometern > 0)
            {
                kilometerstand += streckeInKilometern;
            }
            else
            {
                double verbrauch = streckeInKilometern * verbrauchPro100Km / 100.0;
                tankInhalt -= verbrauch;
            }
        }
    }
}