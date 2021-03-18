
namespace GrandPrix.Models.Tyres
{
    using System;
    public class UltrasoftTyre : Tyre
    {
        private double degradation;

        private const byte MAX_DEGRADATION = 100;
        private const byte MIN_DEGRADATION = 30;

        private const string BLOWN_UP_TYRE = "Tyre has blown up!";
        public UltrasoftTyre(double hardness, double grip)
            :base(hardness)
        {
            this.Name = "Ultrasoft";
            this.Degradation = MAX_DEGRADATION;
            this.Grip = grip;
        }


        override public double Degradation
        {
            get
            {
                return degradation;
            }
            set
            {
                degradation = value;
                if (degradation < MIN_DEGRADATION)
                {
                    throw new Exception(BLOWN_UP_TYRE);
                }
            }
        }
            public double Grip { get; set; }
    

        public override string Type => "Ultrasoft";
    }
}
