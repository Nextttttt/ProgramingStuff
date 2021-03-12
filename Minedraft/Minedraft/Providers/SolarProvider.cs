

namespace Minedraft.Providers
{
using System;
using System.Collections.Generic;
using System.Text;
    class SolarProvider : Provider
    {

        public SolarProvider(string _id, double _energyOutput)
        {

            this.id = _id;
            if (_energyOutput > 10000 || _energyOutput < 0)
            {
                Console.WriteLine(ERROR_MESSAGE + nameof(energyOutput));
                this.id = null;
                return;
            }
            this.energyOutput = _energyOutput;
            Console.WriteLine($"Successfully registered Solar Provider – {_id}");

        }
    }
}
