using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3Math2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Условие Задачи 21: Дано четырехзначное число (ввод с клавиатуры). Найти число, полученное из исходного путем вычеркивания третьей цифры и приписывания ее в начало числа.\r\n");
            Console.WriteLine("Введите четырёхзначное число: \r\n");

            int Main_number = int.Parse(Console.ReadLine());

            // Для выполнения задачи я разобью число на разряды стандартным способом, а потом соберу новое число в консоли. 

            int last_digit = Main_number % 10;

            Main_number = Main_number / 10;

            int third_digit = Main_number % 10;

            Main_number = Main_number / 10;

            Console.WriteLine("У вас получилось число " + third_digit + Main_number + last_digit);
            Console.ReadKey();
        }
    }
}
