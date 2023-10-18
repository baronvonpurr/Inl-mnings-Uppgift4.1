using System;

namespace Uppgift4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int tal = 10;
            while (tal >= 10 && tal <=30)
            {
                Console.WriteLine(tal);
                tal++;
            }

            tal = 200;
            while (tal <= 200 && tal >= 180)
            {
                Console.WriteLine(tal);
                tal--;
            }

            tal = 1000;
            while (tal >= 1000 && tal <= 1400)
            {
                Console.WriteLine(tal);
                tal = tal + 50;
            }
            Console.ReadKey();
        }
    }
}