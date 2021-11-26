using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Recursive
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintAlphabet(FontSize.Lowercase, false);

            Console.ReadKey();
        }

        private enum FontSize
        {
            Uppercase,
            Lowercase
        }

        private static void PrintAlphabet(FontSize type, bool asc)
        {
            //co se stane kdyz nekdo prida polozku do enumu?
            char ASCII_Top = type == FontSize.Lowercase ? 'z' : 'Z';
            char ASCII_Bottom = type == FontSize.Lowercase ? 'a' : 'A';

            /*
            for (char i = ASCII_Bottom; i <= ASCII_Top; i++) 
            {
                PrintChar(i);
            }
            */

            if(asc)
                PrintChars(ASCII_Bottom, ASCII_Top);
            else PrintChars(ASCII_Top, ASCII_Bottom);
        }

        private static void PrintChar(char ch) => Console.WriteLine(ch);

        private static void PrintChars(char start, char end) 
        {    
            PrintChar(start);

            start = start > end ? --start : ++start;

            if (start != end)
                PrintChars(start, end);
            else PrintChar(start);
        }

        private static long GetFactorial(int number)

        {
            if (number == 0)
            {
                return 1;
            }
            return number * GetFactorial(number - 1);
        }
    }
}
