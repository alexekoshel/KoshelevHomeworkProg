using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6_StringsAndSymbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 6.1, Вариант 21");
            Console.WriteLine("Введите текст на русском языке:")
                ;
            string str_Ru = Console.ReadLine();
            string str_Cs = translation(str_Ru);
            Console.WriteLine(str_Cs+"\n");


            Console.WriteLine("Задание 6.2, Вариант 21");
            Console.WriteLine("Дано слово «перевозка», получить слова «веревка» и «повозка».\n" );

            string str_original = "перевозка";
            string str_firstWord = "в" + str_original.Substring(1,4) + str_original.Substring(7,2);
            string str_secondWord = str_original.Substring(0,1) + "о" + str_original.Substring(4,5);
            Console.WriteLine(str_firstWord + ", " + str_secondWord);



            Console.ReadKey();
        }
        static string translation(string str_Ru)
        {
            str_Ru = str_Ru.Replace("А", "A");
            str_Ru = str_Ru.Replace("а", "A");
            str_Ru = str_Ru.Replace("Б", "6");
            str_Ru = str_Ru.Replace("б", "6");
            str_Ru = str_Ru.Replace("В", "B");
            str_Ru = str_Ru.Replace("в", "B");
            str_Ru = str_Ru.Replace("Г", "r");
            str_Ru = str_Ru.Replace("г", "r");
            str_Ru = str_Ru.Replace("Д", "D");
            str_Ru = str_Ru.Replace("д", "D");
            str_Ru = str_Ru.Replace("Е", "Е");
            str_Ru = str_Ru.Replace("е", "Е");
            str_Ru = str_Ru.Replace("Ё", "E");
            str_Ru = str_Ru.Replace("ё", "E");
            str_Ru = str_Ru.Replace("Ж", "}|{");
            str_Ru = str_Ru.Replace("ж", "}|{");
            str_Ru = str_Ru.Replace("З", "3");
            str_Ru = str_Ru.Replace("з", "3");
            str_Ru = str_Ru.Replace("И", "u");
            str_Ru = str_Ru.Replace("и", "u");
            str_Ru = str_Ru.Replace("Й", "u*");
            str_Ru = str_Ru.Replace("й", "u*");
            str_Ru = str_Ru.Replace("К", "K");
            str_Ru = str_Ru.Replace("к", "k");
            str_Ru = str_Ru.Replace("Л", "JI");
            str_Ru = str_Ru.Replace("л", "JI");
            str_Ru = str_Ru.Replace("М", "M");
            str_Ru = str_Ru.Replace("М", "M");
            str_Ru = str_Ru.Replace("Н", "H");
            str_Ru = str_Ru.Replace("н", "H");
            str_Ru = str_Ru.Replace("О", "O");
            str_Ru = str_Ru.Replace("о", "O"); 
            str_Ru = str_Ru.Replace("П", "n");
            str_Ru = str_Ru.Replace("п", "n");
            str_Ru = str_Ru.Replace("Р", "P"); 
            str_Ru = str_Ru.Replace("р", "p");
            str_Ru = str_Ru.Replace("С", "C");
            str_Ru = str_Ru.Replace("с", "C");
            str_Ru = str_Ru.Replace("Т", "T");
            str_Ru = str_Ru.Replace("т", "T");
            str_Ru = str_Ru.Replace("У", "Y");
            str_Ru = str_Ru.Replace("у", "y");
            str_Ru = str_Ru.Replace("Ф", "cp");
            str_Ru = str_Ru.Replace("ф", "cp");
            str_Ru = str_Ru.Replace("Х", "X");
            str_Ru = str_Ru.Replace("х", "x");
            str_Ru = str_Ru.Replace("Ц", "L|");
            str_Ru = str_Ru.Replace("ц", "L|");
            str_Ru = str_Ru.Replace("Ч", "4");
            str_Ru = str_Ru.Replace("ч", "4");
            str_Ru = str_Ru.Replace("Ш", "LLI");
            str_Ru = str_Ru.Replace("ш", "LLI");
            str_Ru = str_Ru.Replace("Щ", "LLL");
            str_Ru = str_Ru.Replace("щ", "LLL");
            str_Ru = str_Ru.Replace("Ъ", "`b");
            str_Ru = str_Ru.Replace("ъ", "`b");
            str_Ru = str_Ru.Replace("Ы", "bI");
            str_Ru = str_Ru.Replace("ы", "bI");
            str_Ru = str_Ru.Replace("Ь", "b");
            str_Ru = str_Ru.Replace("ь", "b");
            str_Ru = str_Ru.Replace("Э", "-)");
            str_Ru = str_Ru.Replace("э", "-)");
            str_Ru = str_Ru.Replace("Ю", "IO");
            str_Ru = str_Ru.Replace("ю", "IO");
            str_Ru = str_Ru.Replace("Я", "9I");
            str_Ru = str_Ru.Replace("я", "9I");
            return str_Ru;
        }
    }
}
