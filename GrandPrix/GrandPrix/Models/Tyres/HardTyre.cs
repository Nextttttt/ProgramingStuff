using System;
using System.Collections.Generic;
using System.Text;

namespace GrandPrix.Models.Tyres
{
    class HardTyre : Tyre
    {
        public HardTyre(double hardness)
            : base(hardness)
        {
            this.Name = "Hard";
        }
        public override string Type => "Hard";

    }
}
