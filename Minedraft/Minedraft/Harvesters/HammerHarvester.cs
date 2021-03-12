using System;
using System.Collections.Generic;
using System.Text;

namespace Minedraft.Harvesters
{
    class HammerHarvester : Harvester
    {

        private double OreOutput = 0;
        private double EnergyRequirement = 0;


        public HammerHarvester(string _id, double _oreOutput, double _energyRequirement)
        {

            this.id = _id;
            if(_oreOutput < 0)
            {
                Console.WriteLine(ERROR_MESSAGE + nameof(oreOutput));
                this.id = null;
                return;
            }
            

            if(_energyRequirement * 2 > 20000)
            {
                Console.WriteLine(ERROR_MESSAGE + nameof(energyRequirement));
                this.id = null;
                return;
            }
            this.oreOutput = _oreOutput;
            this.energyRequirement = _energyRequirement;
            Console.WriteLine($"Successfully registered Hammer Harvester – {_id}");

        }

        public  override double oreOutput 
        {

            get
            {

                return OreOutput;

            }
            set
            {

                    OreOutput = value + value * 2;

            }

        }

        public override double energyRequirement 
        {

            get
            {

                return EnergyRequirement;

            }
            set
            {

                EnergyRequirement = value * 2;

            }

        }

    }
}
