

namespace GrandPrix.Factories
{

    using System;
    using System.Collections.Generic;
    using System.Text;
    using GrandPrix.Models.Tyres;
    class TyreFactory
    {

        public Tyre Create(string tyreType, double tyreHardness, double grip)
        {
            Tyre tyre = null;
            switch(tyreType)
            {
                case "Ultrasoft":
                    {
                        tyre = new UltrasoftTyre(tyreHardness, grip);
                        break;
                    }
                case "Hard":
                    {
                        tyre = new HardTyre(tyreHardness);
                        break;
                    }
            }


            return tyre;

        }

    }
}
