using System;

namespace HydroNoRain
{
    class HydroNoRain
    {
        static void EnterHydroArray(int n, double[] Array)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Insert HydroGraph Data for {i} Day:");
                Array[i] = double.Parse(Console.ReadLine());
            }
        }

        static int NoRainyDays(int n, double[] Array)
        {
            int daysWithoutRain = 0;
            for (int i = 0; i < n; i++)
            {
                if (Array[i] == 0)
                {

                    daysWithoutRain ++;

                }
            }
            return daysWithoutRain;
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

            Console.WriteLine($"Days without rain for Station 1: {NoRainyDays(daysCount, A)}");
            Console.WriteLine($"Days without rain for Station 2: {NoRainyDays(daysCount, B)}");
            Console.WriteLine($"Days without rain for Station 3: {NoRainyDays(daysCount, C)}");

            for(int i = 0; i <= daysCount; i ++)
            {

                if(A[i] != 0 || B[i] != 0  || C[i] != 0)
                {

                    Console.Write($"Rainy days: {i}");

                }

            }
        }

        }
    }
