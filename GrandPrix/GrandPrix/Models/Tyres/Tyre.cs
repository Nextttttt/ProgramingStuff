
namespace GrandPrix.Models.Tyres
{

    using System;

    public abstract class Tyre
    {

        private double degradation;

        private const byte MAX_DEGRADATION = 100;
        private const byte MIN_DEGRADATION = 0;

        private const string BLOWN_UP_TYRE = "Tyre has blown up!";

        public Tyre(double hardness)
        {
            this.Hardness = hardness;
            this.Degradation = MAX_DEGRADATION;
        }

        public string Name { get; set; }
        public double Hardness { get; set; }
        public virtual double Degradation 
        { 
            get
            {
                return degradation;
            }
            set
            {
                degradation = value;
                if(degradation <= MIN_DEGRADATION)
                {
                    throw new Exception(BLOWN_UP_TYRE);
                }

            }
        }

        public abstract string Type { get; }

    }
}
