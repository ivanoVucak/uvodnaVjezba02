using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uvodnaVjezba02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 7;
            double c = 12.5, d = 16.7;
            double x;

            x = (a + b + c + d)/4;
            Console.WriteLine("Prosječna vrijednost brojeva 10, 7, 12.5, 16.7 je " + x);

            Console.ReadKey();


        }
    }
}
