
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

            switch(type)
            {
                case "Agressive":
                    {
                        driver = new AgressiveDriver(name, hp, fuelAmount, tyreType, tyreHardness)
                        break;
                    }
                case "Endurance":
                    {
                        break;
                    }
            }
        }
    }
}
