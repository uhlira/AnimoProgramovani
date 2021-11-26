using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulacka2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Zadejte cislo 1");
            string cislo1 = Console.ReadLine();

            Console.WriteLine("Zadejte cislo 2");
            string cislo2 = Console.ReadLine();

            Console.WriteLine("Zadejte operaci + - * /");
            string operace = Console.ReadLine();
            int vysledek = int.MinValue;
            bool ok = true;

            switch (operace) 
            {
                case "+": vysledek = Convert.ToInt32(cislo1) + Convert.ToInt32(cislo2);
                    break;

                case "-":
                    vysledek = Convert.ToInt32(cislo1) - Convert.ToInt32(cislo2);
                    break;

                case "*":
                    vysledek = Convert.ToInt32(cislo1) * Convert.ToInt32(cislo2);
                    break;

                case "/":
                    vysledek = Convert.ToInt32(cislo1) / Convert.ToInt32(cislo2);
                    break;

                default: ok = false;
                    break;
            }

            if(ok) Console.WriteLine("Vysledkem je " + vysledek);
            else Console.WriteLine("Zadali jste spatnou operaci");

            if (operace == "+" ||  operace == "-" || operace == "*" || operace == "/") 
            {               
                if (operace == "+")
                {
                    vysledek = Convert.ToInt32(cislo1) + Convert.ToInt32(cislo2);
                }

                if (operace == "-")
                {
                    vysledek = Convert.ToInt32(cislo1) - Convert.ToInt32(cislo2);
                }

                if (operace == "*")
                {
                    vysledek = Convert.ToInt32(cislo1) * Convert.ToInt32(cislo2);
                }

                if (operace == "/")
                {
                    vysledek = Convert.ToInt32(cislo1) / Convert.ToInt32(cislo2);
                }

                Console.WriteLine("Vysledkem je " + vysledek);
            }
            else Console.WriteLine("Zadali jste spatnou operaci");
            */

            Console.WriteLine("ErrorLog" + DateTime.Now.ToString("yyMMdd_HHmmss"));

            //File.AppendText(path);
            //File.WriteAllText()

            Console.ReadKey();
        }
    }
}
