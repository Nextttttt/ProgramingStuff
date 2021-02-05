using System;

namespace Exam.DetailsMade
{
    class Program
    {
        static void InputDetailsMade(int[] Array, int n)
        {

            for(int i = 0; i < n; i++)
            {

                Console.Write($"Профили за ден {i+1}: ");
                Array[i] = int.Parse(Console.ReadLine());

            }

        }

        static void MoreThenAverage(int[] Array, int n)
        {
            int sumDetails = 0;
            double averageDetails = 0;
            for(int i = 0; i < n; i++)
            {

                sumDetails = sumDetails + Array[i];

            }
            averageDetails = sumDetails / n;
            Console.WriteLine("Повече профили от средното за този работник са произведени през:");
            for(int i = 0; i < n; i++)
            {

                if(Array[i] > averageDetails)
                {

                    Console.Write($"Ден {i + 1}, ");

                }

            }
            Console.WriteLine();

        }
        static void DetailsMoreThen25(int[] Array, int n)
        {

            for (int i = 0; i < n; i++)
            {

                if (Array[i] > 25)
                {

                    Console.Write($"Ден {i + 1}, ");

                }

            }
            Console.WriteLine();


        }
        static void MaxandMinDetails(int[] Array, int n)
        {

            int maxDetails = Array[0];
            int minDetails = Array[0];

            for(int i = 1; i < n; i++)
            {

                if(Array[i] > maxDetails)
                {

                    maxDetails = Array[i];

                }
               
            }
            for (int i = 1; i < n; i++)
            {

                if (Array[i] < maxDetails)
                {

                    minDetails = Array[i];

                }

            }
            Console.WriteLine("Дни през, които работникът е изработил максимален брой профили: ");
            for(int i = 0; i < n; i++)
            {

                if(Array[i] == maxDetails)
                {

                    Console.Write($"Ден {i + 1}, ");

                }

            }
            Console.WriteLine();
            Console.WriteLine("Дни през, които работникът е изработил минимален брой профили: ");
            for (int i = 0; i < n; i++)
            {

                if (Array[i] == minDetails)
                {

                    Console.Write($"Ден {i + 1}, ");

                }

            }
            Console.WriteLine();

        }
        static void Main(string[] args)
        {
            Console.Write("Въведете броя работни дни за месеца:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("===============================================================================");
            int[] A = new int[n];
            int[] B = new int[n];
            int[] C = new int[n];
            //=========================================================
            Console.WriteLine("Въведете детайлите изработени от работник 1 за всеки работен ден от месеца:");
            InputDetailsMade(A, n);
            Console.WriteLine("Въведете детайлите изработени от работник 2 за всеки работен ден от месеца:");
            InputDetailsMade(B, n);
            Console.WriteLine("Въведете детайлите изработени от работник 3 за всеки работен ден от месеца:");
            InputDetailsMade(C, n);
            Console.WriteLine("===============================================================================");
            Console.WriteLine();
            //=========================================================
            MoreThenAverage(A, n);
            MoreThenAverage(B, n);
            MoreThenAverage(C, n);
            Console.WriteLine("===============================================================================");
            //=========================================================
            Console.WriteLine("Дните през които работник 1 е произвел повече от 25 профила са: ");
            DetailsMoreThen25(A, n);
            Console.WriteLine("Дните през които работник 2 е произвел повече от 25 профила са: ");
            DetailsMoreThen25(B, n);
            Console.WriteLine("Дните през които работник 3 е произвел повече от 25 профила са: ");
            DetailsMoreThen25(C, n);
            Console.WriteLine("===============================================================================");
            //=========================================================
            Console.WriteLine("За работник 1:");
            MaxandMinDetails(A, n);
            Console.WriteLine();
            Console.WriteLine("За работник 2:");
            MaxandMinDetails(B, n);
            Console.WriteLine();
            Console.WriteLine("За работник 3:");
            MaxandMinDetails(C, n);
            Console.WriteLine();
            Console.WriteLine("===============================================================================");



        }
    }
}
