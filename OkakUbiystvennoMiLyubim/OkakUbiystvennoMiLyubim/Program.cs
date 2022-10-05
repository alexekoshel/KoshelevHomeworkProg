using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkakUbiystvennoMiLyubim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Федор Тютчев\r\n");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("О, как убийственно мы любим\r\n");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("О, как убийственно мы любим," +
                "\r\nКак в буйной слепоте страстей" +
                "\r\nМы то всего вернее губим," +
                "\r\nЧто сердцу нашему милей!" +
                "\r\n\r\nДавно ль, гордясь своей победой," +
                "\r\nТы говорил: она моя..." +
                "\r\nГод не прошел - спроси и сведай," +
                "\r\nЧто уцелело от нея?");
            
            Console.ResetColor();
          
            Console.ReadKey();

        }
    }
}
