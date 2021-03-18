

namespace GrandPrix.Models.Drivers
{

    
    public class AgressiveDriver : Driver
    {

        private const double SPEED_MULTIPLIER = 1.3;
        private const double FUEL_CONSUMPTION_INDEX = 2.7;

        public AgressiveDriver(string name, int hp, double fuelAmount, string tyreType, double tyreHardness, double grip)
            :base(name, hp, fuelAmount, tyreType, tyreHardness, grip)
        {

            this.FuelConsumptionPerKm = FUEL_CONSUMPTION_INDEX;
            this.Speed *= SPEED_MULTIPLIER;

        }

        public override string Type => "Agressive";

    }
}
