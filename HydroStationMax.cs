using System;

namespace HydroStationMax
{
    class HydroStationMax
    {
        static void EnterHydroArray(int n, double[] Array)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Insert HydroGraph Data for {i} Day:");
                Array[i] = double.Parse(Console.ReadLine());
            }
        }

        static double MaxRainVolume(int n, double[] Array)
        {
            double maxRain = 0;
            for (int i = 0; i < n; i++)
            {
                if(Array[i] > maxRain)
                {

                    maxRain = Array[i];

                }
            }
            return maxRain;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Insert days in month:");
            int daysCount = int.Parse(Console.ReadLine());
            double[] A = new double[daysCount];
            double[] B = new double[daysCount];
            double[] C = new double[daysCount];

            double maxRain = 0;

            int counterA = 0;
            int counterB = 0;
            int counterC = 0;

            EnterHydroArray(daysCount, A);
            EnterHydroArray(daysCount, B);
            EnterHydroArray(daysCount, C);

            if(MaxRainVolume(daysCount,A) > MaxRainVolume(daysCount,B))
            {

                maxRain = MaxRainVolume(daysCount, A);

                if (maxRain < MaxRainVolume(daysCount,C))
                {

                    maxRain = MaxRainVolume(daysCount, C);

                }

            }
            else
            {
                maxRain = MaxRainVolume(daysCount, B);

                if (maxRain < MaxRainVolume(daysCount, C))
                {

                    maxRain = MaxRainVolume(daysCount, C);

                }

            }

            Console.WriteLine($"Max rain volume is {maxRain}");

            for(int i = 0; i <= daysCount; i ++)
            {

                if(A[i] == maxRain)
                {

                    counterA++;

                }
                if (B[i] == maxRain)
                {

                    counterB++;

                }
                if (C[i] == maxRain)
                {

                    counterC++;

                }

                Console.WriteLine($"Days with rain equal to the max rain for Station 1 are: {counterA}");
                Console.WriteLine($"Days with rain equal to the max rain for Station 2 are: {counterB}");
                Console.WriteLine($"Days with rain equal to the max rain for Station 3 are: {counterC}");

            }
        }
    }
}
