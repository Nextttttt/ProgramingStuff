

namespace GrandPrix.Models.Drivers
{
    class EnduranceDriver : Driver
    {


        private const double FUEL_CONSUMPTION_INDEX = 1.5;

        public EnduranceDriver(string name, int hp, double fuelAmount, string tyreType, double tyreHardness, double grip)
            : base(name, hp, fuelAmount, tyreType,tyreHardness, grip)
        {

            this.FuelConsumptionPerKm = FUEL_CONSUMPTION_INDEX;

        }
        public EnduranceDriver(string name, int hp, double fuelAmount, string tyreType, double tyreHardness)
            : base(name, hp, fuelAmount, tyreType, tyreHardness)
        {

            this.FuelConsumptionPerKm = FUEL_CONSUMPTION_INDEX;

        }


        public override string Type => "Endurance";
    }
}
