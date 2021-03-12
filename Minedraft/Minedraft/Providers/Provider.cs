namespace Minedraft.Providers
{

    using System;
    using System.Collections.Generic;
    using System.Text;

    abstract class Provider
    {
        public const string ERROR_MESSAGE = "Provider is not registered, because of it's ";

        private double EnergyOutput = 0;

        public string id { get; set; }
        public virtual double energyOutput 
        { 
            get
            {
                return EnergyOutput;
            }

            set
            {

                if(value < 0)
                {
                    throw new Exception(ERROR_MESSAGE + nameof(energyOutput));
                }

                if(value > 10000)
                {

                    throw new Exception(ERROR_MESSAGE + nameof(energyOutput));

                }
                else
                    EnergyOutput = value;

            }
        }

    }
}
