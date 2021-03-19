

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
                             
                       tyre = new UltrasoftTyre(tyreHardness, grip);
                      
            return tyre;

        }
        public Tyre Create(string tyreType, double tyreHardness)
        {
            Tyre tyre = null;
                 
                        tyre = new HardTyre(tyreHardness);

            return tyre;

        }

    }
}
