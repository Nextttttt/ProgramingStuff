using System;

namespace HydroMonthAvarage
{
    class HydroMonthAvarage
    {

        static void EnterHydroArray(int n, double[] Array)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Insert HydroGraph Data for {i} Day:");
                Array[i] = double.Parse(Console.ReadLine());
            }
        }

        static double AvarageRainCalc(int n, double[] Array)
        {
            int rainCount = 0;
            double rainSum = 0;
            for (int i = 0; i < n; i++)
            {
                if (Array[i] != 0)
                {
                    rainCount++;
                    rainSum += Array[i];
                }
            }
            return rainSum / rainCount;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Insert days in month:");
            int daysCount = int.Parse(Console.ReadLine());
            double[] A = new double[daysCount];
            double[] B = new double[daysCount];
            double[] C = new double[daysCount];

         
            EnterHydroArray(daysCount, A);
            EnterHydroArray(daysCount, B);
            EnterHydroArray(daysCount, C);

            Console.WriteLine($"The avarage rain volume for Station 1 is:{AvarageRainCalc(daysCount, A)}");
            Console.WriteLine($"The avarage rain volume for Station 2 is:{AvarageRainCalc(daysCount, B)}");
            Console.WriteLine($"The avarage rain volume for Station 3 is:{AvarageRainCalc(daysCount, C)}");

            Console.WriteLine();

            Console.Write("Days with more rain valume then the avarage for Station 1: ");
            for (int i = 0; i < daysCount; i++)
            {

                if (A[i] > AvarageRainCalc(daysCount, A))
                {
                    Console.Write(i + " ");
                }
                
            }

            Console.WriteLine();

            Console.Write("Days with more rain valume then the avarage for Station 2: ");

            for (int i = 0; i < daysCount; i++)
            {

                if (B[i] > AvarageRainCalc(daysCount, B))
                {
                    Console.Write(i + " ");
                }

            }

            Console.WriteLine();

            Console.Write("Days with more rain valume then the avarage for Station 3: ");

            for (int i = 0; i < daysCount; i++)
            {

                if (C[i] > AvarageRainCalc(daysCount, C))
                {
                    Console.Write(i + " ");
                }

            }

            Console.WriteLine();

        }
    }
}
