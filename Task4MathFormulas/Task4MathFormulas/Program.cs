using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4MathFormulas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задачa 21:\r\n");
            Console.WriteLine("Введите значение X:\r\n");

            double x = double.Parse(Console.ReadLine());

            double y = Math.Abs( 2 * Math.Sin( -3 * Math.Abs((x+1)/2)));

            Console.WriteLine("Значение у = " + y);
            Console.ReadKey();
        }
    }
}
