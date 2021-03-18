﻿
namespace GrandPrix.Models.Drivers
{
    using GrandPrix.Models.Tyres;
    using GrandPrix.Factories;
    public abstract class Driver : BaseModel
    {

        private double speed;
        TyreFactory tyreFactory;
        

        public Driver(string name,int hp,double fuelAmount, string tyreType, double tyreHardness, double grip)
            :base(name)
        {

            this.Car.HP = hp;
            this.Car.FuelAmount = fuelAmount;

            Car.Tyre = tyreFactory.Create(tyreType, tyreHardness, grip);


        }

        public double TotalTime { get; set; }
        public Car Car { get; set; }
        public double FuelConsumptionPerKm { get; set; }
        public double Speed 
        { 
            get
            {
                return speed;
            }
            set
            {

                speed = (Car.HP + Car.Tyre.Degradation) / Car.FuelAmount;

            }
        }

    }
}
