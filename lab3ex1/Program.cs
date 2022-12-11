using System;

namespace lab3ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Scrieti o functie care va calcula suma cifrelor unui numar. */

            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(SumaCifrelor(n));

            static int SumaCifrelor(int n)
            {
                int suma = 0;
                while(n>0)
                {
                    suma = suma + n%10;
                    n = n / 10;
                }
                return suma;
            }
        }
    }
}
