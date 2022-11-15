using System;


namespace Task8If
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Вариант 21");
            Console.WriteLine("Введите значение X");

            double x  = double.Parse(Console.ReadLine());

            Console.WriteLine("F(x) = " + calculation(x),3);


            Console.ReadKey();
        }

        static double calculation(double x)
        {
            if (Math.Cos(x) != 0)  
                return Math.Tan(x);

            if ((Math.Cos(x) == 0) && (Math.Sin(x) > 0))
                return (x / Math.PI) - 0.5;

            return (x / Math.PI) * -1 - 0.5;
        }

    }
}
