
namespace GrandPrix.Factories
{

    using System;
    using System.Collections.Generic;
    using System.Text;
    using GrandPrix.Models.Drivers;

    public class DriverFactory
    {
        public Driver Create(List<string> commandArgs)
        {
            Driver driver = null;

            string type = commandArgs[0];
            string name = commandArgs[1];
            int hp = int.Parse(commandArgs[2]);
            double fuelAmount = double.Parse(commandArgs[3]);
            string tyreType = commandArgs[4];
            double tyreHardness = double.Parse(commandArgs[5]);
            double grip = double.Parse(commandArgs[6]);

            switch(type)
            {
                case "Aggressive":
                    {
                        driver = new AgressiveDriver(name, hp, fuelAmount, tyreType, tyreHardness, grip);
                        break;
                    }
                case "Endurance":
                    {
                        driver = new EnduranceDriver(name, hp, fuelAmount, tyreType, tyreHardness, grip);
                        break;
                    }
            }

            return driver;
        }
    }
}
