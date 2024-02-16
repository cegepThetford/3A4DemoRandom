using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DemoRandom_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand1 = new Random();
            Random rand2 = new Random();
            Thread.Sleep(20);
            Random rand3 = new Random();
            afficherSerieNombres(rand1);
            afficherSerieNombres(rand2);
            afficherSerieNombres(rand3);
            Console.ReadLine();
        }

        private static void afficherSerieNombres(Random rand)
        {
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
                Console.Write("{0,5}", rand.Next(1, 100));
            Console.WriteLine();
        }
    }
}
