namespace Fuhrparkverwaltung
{
    public class Auto
    {
        private int kilometerstand;

        public Auto(int kilometerstand)
        {
            this.kilometerstand = kilometerstand;
        }

        public void Fahren(int streckeInKilometern)
        {
            if (streckeInKilometern > 0)
            {
                kilometerstand += streckeInKilometern;
            }
        }

        public int Kilometerstand
        {
            get
            {
                return kilometerstand;
            }
        }
    }
}