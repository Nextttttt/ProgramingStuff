
namespace Minedraft
{
    
    using System;
    using System.Collections.Generic;
    using System.Text;

    abstract class Harvester
    {

        public const string ERROR_MESSAGE = "Harvester is not registered, because of it's  ";

        private double OreOutput = 0;
        private double EnergyRequirement = 0;
        public string id
        {
            get;
            set;
        }

        public virtual double oreOutput
        {
            get
            {
                return OreOutput;
            }
            set
            {
                
                if (value < 0)
                {

                    throw new Exception(ERROR_MESSAGE + nameof(oreOutput));

                }
                else
                    OreOutput = value;

            }
        }

        public virtual double energyRequirement
        {
            get
            {

                return EnergyRequirement;

            }
            set
            {

                if (value < 0)
                {

                    throw new Exception(ERROR_MESSAGE + nameof(energyRequirement));

                }

                if(value > 20000)
                {

                    throw new Exception(ERROR_MESSAGE + nameof(energyRequirement));

                }
                else
                    EnergyRequirement = value;

            }
        }


    }
}
