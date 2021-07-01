using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharPrinter
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PrintLine("#", 5, Direction.HORIZONTAL);

                Console.WriteLine();

                PrintLine("&", 10, Direction.VERTICAL);

                PrintRectangle("#", 10);

                PrintFall("#", 5, Direction.FALLING);
            }
            catch (Exception e) 
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }

        static void PrintLine(string printChar, int length, Direction direction) 
        {
            switch (direction)             
            {
                case Direction.HORIZONTAL:
                    for (int i = 0; i < length; i++)
                        Console.Write(printChar);
                    break;

                case Direction.VERTICAL:
                    for (int i = 0; i < length; i++)
                        Console.WriteLine(printChar);
                    break;

                default: Console.WriteLine("Unknown rotation type");
                    break;
            }

            Console.WriteLine();
        }

        static void PrintRectangle(string printChar, int length) 
        {
            PrintLine(printChar, length, Direction.HORIZONTAL);

            for (int i = 0; i < length-2; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if (j == 0 || j == length - 1) Console.Write(printChar);
                    else Console.Write(" ");
                }

                Console.WriteLine();
            }

            PrintLine(printChar, length, Direction.HORIZONTAL);

            Console.WriteLine();
        }

        static void PrintFall(string printChar, int length, Direction direction)
        {
            switch (direction)
            {
                case Direction.RISING:
                    for (int i = 0; i < length; i++)
                    {
                        for (int j = 0; j <= i; j++)
                        {
                            Console.Write(printChar);
                        }

                        Console.WriteLine();
                    }
                    break;

                case Direction.FALLING:
                    for (int i = length; i > 0; i--)
                    {
                        for (int j = 0; j < i; j++)
                        {
                            Console.Write(printChar);
                        }

                        Console.WriteLine();
                    }
                    break;

                default:
                    Console.WriteLine("Unknown direction type");
                    break;
            }


            Console.WriteLine();
        }

        static void PrintPyramid(string printChar, int length, Direction direction)
        {
            for (int i = 0; i < length; i++)
            {
                for (int j = length/2; j < 0; j--)
                {
                    Console.Write(printChar);
                }
            }

            Console.WriteLine();
        }

        enum Direction 
        {
            HORIZONTAL, 
            VERTICAL, 
            FALLING, 
            RISING
        }

    }
}
