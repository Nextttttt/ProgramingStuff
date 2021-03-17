
namespace GrandPrix.Models.Drivers
{

    public abstract class Driver : BaseModel
    {

        private double speed;

        

        public Driver(string name,double totalTime, Car car)
            :base(name)
        {

            this.TotalTime = totalTime;
            this.Car = car;

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
