using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] { "Adam", "Tomáš", "Daria", "Viky", "Pepa" };
            Random random = new Random(DateTime.Now.Millisecond);

            int randomNumber = random.Next(0, 5);
            Console.WriteLine(names[randomNumber]);

            int escapeCounter = 0;

            /*
            while(true)
            {
                ConsoleKey key = Console.ReadKey().Key;
                if (key == ConsoleKey.Escape)
                {
                    escapeCounter++;

                    if (escapeCounter == 1)
                    {
                        Console.WriteLine("Escape1");
                    }

                    if (escapeCounter == 2)
                    {
                        Console.WriteLine("Escape2");
                    }

                    if (escapeCounter == 3)
                    {
                        break;
                    }
                }
            }
            */
            int number = 0;
            StringBuilder sb = new StringBuilder();

            ChangeValue(number, sb);

            Console.WriteLine(number + "   " + sb.ToString());

            Console.ReadLine();
        }

        public static void ChangeValue(int number, StringBuilder sb) 
        {
            number++;
            sb.AppendLine("Value");
        }
    }
}
