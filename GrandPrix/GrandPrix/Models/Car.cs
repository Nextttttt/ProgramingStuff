
namespace GrandPrix.Models
{

    using System;
    using GrandPrix.Models.Tyres;

    public class Car
    {
        private double fuelAmount;

        private const int MAX_FUEL_AMOUNT = 160;
        private const int MIN_FUEL_AMOUNT = 0;

        private const string OUT_OF_FUEL = "The car is out of fuel, the driver cannot continue the race!";
        public Car(int hp, Tyre tyre)
        {
            this.HP = hp;
            this.Tyre = tyre;
            this.FuelAmount = MAX_FUEL_AMOUNT;
        }
        public int HP { get; set; }
        public double FuelAmount 
        { 
            get
            {
                return fuelAmount;
            }
            set
            {
                fuelAmount = value;
                if(fuelAmount <= MIN_FUEL_AMOUNT)
                {
                    throw new Exception(OUT_OF_FUEL);
                }
                if(fuelAmount > MAX_FUEL_AMOUNT)
                {
                    fuelAmount = MAX_FUEL_AMOUNT;
                }
            }
        }
        public Tyre Tyre { get; set; }

    }
}
