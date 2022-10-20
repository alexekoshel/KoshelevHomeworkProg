using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task05Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задача 21.");

            double x = part1(1,2) + part1(2,2) + part1(3,5) + part1(4,3);

            Console.WriteLine("x = " + Math.Round(x, 3));
            Console.ReadKey();

        }

        static double part1(int x, int y)
        {
            return (x + Math.Pow(Math.E, -x)) / y;
        }
    }
}
