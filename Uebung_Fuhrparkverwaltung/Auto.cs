using Newtonsoft.Json.Linq;

namespace Fuhrparkverwaltung
{
    public class Auto
    {
        private int kilometerstand;
        private int streckeInKilometern;
        private double tankInhalt;
        private double verbrauchPro100Km;

        public int Kilometerstand
        {
            get
            {
                return kilometerstand;
            }
            set
            {
                if ( value >= 175)
                {
                    kilometerstand = value;
                }
                else
                {
                    throw new Exception("Fahrzeug kann nicht über 175km Fahren.");
                }
            }
        }

        public double TankInhalt
        {
            get
            {
                return tankInhalt;
            }
            set
            {
                if (value < 0)
                {
                    tankInhalt = 0;
                }
                else
                {
                    tankInhalt = value;
                }
            }
        }

        public Auto(int kilometerstand)
        {
            this.kilometerstand = kilometerstand;
        }

        public Auto(int kilometerstand, double tankInhalt) : this(kilometerstand)
        {
            this.tankInhalt = tankInhalt;
        }

        public Auto(int kilometerstand, double tankInhalt, double verbauchPro100Km) : this(kilometerstand)
        {
            this.verbrauchPro100Km = verbauchPro100Km;
        }


        public void Fahren(int streckeInKilometern)
        {
            if (streckeInKilometern > 0)
            {
                kilometerstand += streckeInKilometern;
            }
            else
            {
                throw new Exception("Streckendistanz muss Größer als 0km sein!");
            }

            if (streckeInKilometern >= 100)
            {
                tankInhalt -= 5.7;
            }
        }
    }
}