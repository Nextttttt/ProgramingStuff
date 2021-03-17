

namespace GrandPrix.Models.Drivers
{
    class EnduranceDriver : Driver
    {


        private const double FUEL_CONSUMPTION_INDEX = 1.5;

        public EnduranceDriver(string name, double totalTime, Car car)
            : base(name, totalTime, car)
        {


            this.FuelConsumptionPerKm = FUEL_CONSUMPTION_INDEX;

        }


        public override string Type => "Endurance";
    }
}
