

namespace Minedraft.Harvesters
{

    using System;
    using System.Collections.Generic;
    using System.Text;
    using Harvesters;

    class SonicHarvester : Harvester
    {

        private double EnergyRequirement = 0;
        private int SonicFactor = 0;
        
        public SonicHarvester(string _id, double _oreOutput, double _energyRequirement, int _SonicFactor)
        {

            this.id = _id;
            if (_oreOutput < 0)
            {
                Console.WriteLine(ERROR_MESSAGE + nameof(oreOutput));
                this.id = null;
                return;
            }
            

            if (_energyRequirement * 2 > 20000)
            {
                Console.WriteLine(ERROR_MESSAGE + nameof(energyRequirement));
                this.id = null;
                return;
            }
            this.oreOutput = _oreOutput;
            this.energyRequirement = _energyRequirement / _SonicFactor;

            this.sonicFactor = _SonicFactor;
            Console.WriteLine($"Successfully registered Sonic Harvester – {_id}");

        }
        public int sonicFactor 
        { 
            get
            {

                return SonicFactor;

            }
            set
            {

                SonicFactor = value;

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

                    EnergyRequirement = value;

            }

        }

        
    }
}
