namespace Minedraft.Providers
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class PressureProvider : Provider
    {

        private double EnergyOutput = 0;

        public PressureProvider(string _id, double _energyOutput)
        {

            this.id = _id;
            if(_energyOutput + _energyOutput * 0.5 > 10000 || _energyOutput < 0)
            {
                Console.WriteLine(ERROR_MESSAGE + nameof(energyOutput));
                this.id = null;
                return;
            }
            this.energyOutput = _energyOutput;
            Console.WriteLine($"Successfully registered Pressure Provider – {_id}");

        }

        public override double energyOutput
        {

            get
            {
                return EnergyOutput;
            }

            set
            {

                
                    EnergyOutput = value + value * 0.5;

            }

        }

    }
}
