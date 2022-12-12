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
        // oder 2. Version?
        //public void Fahren(int streckeInKilometern)
        //{
        //    if (streckeInKilometern <= 0)
        //    {
        //        throw new ArgumentException("Die Entfernung muss größer als 0 sein.");
        //    }
        //    kilometerstand += streckeInKilometern;
        //}

        public int Kilometerstand
        {
            get
            {
                return kilometerstand;
            }
        }
    }
}