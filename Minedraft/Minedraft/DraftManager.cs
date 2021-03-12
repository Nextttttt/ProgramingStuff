namespace Minedraft
{

    using Harvesters;
    using Providers;
    using System;
    using System.Collections.Generic;

    class DraftManager
    {
        static List<Harvester> harvesters = new List<Harvester>();
        static List<Provider> providers = new List<Provider>();

        static double storedEnergy;
        static double storedOre;

        static string workMode = "Full";

        public static void RegisterHarvester(List<string> arguments)
        {

            string type = arguments[1];
            string id = arguments[2];
            double oreOutput = double.Parse(arguments[3]);
            double energyRequirements = double.Parse(arguments[4]);

            switch (type)
            {
                case "Sonic":
                    {
                        int sonicFactor = int.Parse(arguments[5]);
                        
                        harvesters.Add(new SonicHarvester(id, oreOutput, energyRequirements, sonicFactor));

                        break;

                        

                    }

                case "Hammer":
                    {
                        
                        harvesters.Add(new HammerHarvester(id, oreOutput, energyRequirements));
                        if (oreOutput == 0 || energyRequirements == 0)
                            harvesters.Remove(new HammerHarvester(id, oreOutput, energyRequirements));
                        break;

                    }
                    
            }

        }
        public static void RegisterProvider(List<string> arguments)
        {

            string type = arguments[1];
            string id = arguments[2];
            double energyOutput = double.Parse(arguments[3]);

            switch (type)
            {
                case "Solar":
                    {
                        
                            providers.Add(new SolarProvider(id, energyOutput));

                        break;

                    }
                case "Pressure":
                    {

                        
                            providers.Add(new PressureProvider(id, energyOutput));

                        break;

                    }
            }
           
     
        }
        public static void Day()
        {

            double summedEnergyOutput = 0;
            double summedEnergyConsumption = 0;
            double summedOreOutput = 0;

            Console.WriteLine("A Day has passed.");

            switch (workMode)
            {
                case "Full":
                    {
                        foreach (var item in providers)
                        {
                            summedEnergyOutput += item.energyOutput;
                        }

                        storedEnergy += summedEnergyOutput;

                        foreach (var item in harvesters)
                        {
                            summedEnergyConsumption += item.energyRequirement;
                            summedOreOutput += item.oreOutput;
                        }

                        

                        if (summedEnergyConsumption <= storedEnergy)
                        {

                            storedEnergy -= summedEnergyConsumption;
                            storedOre += summedOreOutput;

                        }
                        else
                        {

                            summedOreOutput = 0;

                        }

                        Console.WriteLine($"Energy Provided: {summedEnergyOutput}");
                        Console.WriteLine($"Plumbus Ore Mined: {summedOreOutput}");

                        break;

                    }

                case "Half":
                    {
                        foreach (var item in providers)
                        {
                            summedEnergyOutput += item.energyOutput;
                        }

                        storedEnergy += summedEnergyOutput;

                        foreach (var item in harvesters)
                        {
                            summedEnergyConsumption += item.energyRequirement * 0.6;
                            summedOreOutput += item.oreOutput * 0.5;
                        }

                        

                        if (summedEnergyConsumption <= storedEnergy)
                        {

                            storedEnergy -= summedEnergyConsumption;
                            storedOre += summedOreOutput;
                          
                        }
                        else
                        {

                            summedOreOutput = 0;

                        }

                        Console.WriteLine($"Energy Provided: {summedEnergyOutput}");
                        Console.WriteLine($"Plumbus Ore Mined: {summedOreOutput}");

                        break;

                    }

                case "Energy":
                    {

                        foreach (var item in providers)
                        {
                            summedEnergyOutput += item.energyOutput;
                        }

                        storedEnergy += summedEnergyOutput;

                        Console.WriteLine($"Energy Provided: {summedEnergyOutput}");
                        Console.WriteLine($"Plumbus Ore Mined: {summedOreOutput}");

                        break;

                    }
            }

        }
        public static void Mode(List<string> arguments)
        {

            string mode = arguments[1];
            switch (mode)
            {
                case "Full":
                    {

                        workMode = "Full";
                        break;

                    }

                case "Half":
                    {
                        workMode = "Half";
                        break;
                    }

                case "Energy":
                    {
                        workMode = "Energy";
                        break;
                    }

            }

            Console.WriteLine($"Successfully changed working mode to {mode} Mode");

        }
        public static void Check(List<string> arguments)
        {

            string checkedId = arguments[1];
            foreach (var item in providers)
            {
                if (item.id == checkedId)
                {

                    if (item.GetType().Name == "SolarProvider")
                    {
                        Console.WriteLine($"Solar Provider - {item.id} \n Energy Output: {item.energyOutput}");

                    }
                    else
                    {

                        Console.WriteLine($"Pressure Provider - {item.id} \n Energy Output: {item.energyOutput}");


                    }

                    return;

                }
            }
            foreach (var item in harvesters)
            {
                if (item.id == checkedId)
                {
                    if (item.GetType().Name == "SonicHarvester")
                    {
                        Console.WriteLine($"Sonic Harvester - {item.id} \n Ore Output: {item.oreOutput} \n Energy Requirement: {item.energyRequirement}");
                    }
                    else
                    {

                        Console.WriteLine($"Hammer Harvester - {item.id} \n Ore Output: {item.oreOutput} \n Energy Requirement: {item.energyRequirement}");

                    }

                    return;

                }
            }

            Console.WriteLine($"No element found with id – {checkedId}");

        }
        public static string ShutDown()
        {

            return ($"System Shutdown \n Total Energy Stored: {storedEnergy} \n Total Mined Plumbus Ore: {storedOre}.");

        }

    }
}
