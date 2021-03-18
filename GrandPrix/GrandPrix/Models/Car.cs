
namespace GrandPrix.Models
{

    using System;
    using GrandPrix.Models.Tyres;
    using Factories;

    public class Car
    {
        private double fuelAmount;
        private TyreFactory tyreFactory;

        private const int MAX_FUEL_AMOUNT = 160;
        private const int MIN_FUEL_AMOUNT = 0;

        private const string OUT_OF_FUEL = "The car is out of fuel, the driver cannot continue the race!";
        public Car(int hp, double fuelAmount, string tyreType, double tyreHardness, double grip)
        {
            this.HP = hp;
            this.FuelAmount = fuelAmount;
            this.Tyre = tyreFactory.Create(tyreType, tyreHardness, grip);
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
