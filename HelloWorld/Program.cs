using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                Console.Write("Zadej opcet opakovani vypoctu: ");
                int pocet = Convert.ToInt32(Console.ReadLine());

                //int cislo = 5;
                /*
                int[] poleCisel = new int[10];
                
                for (int i = 0; i < poleCisel.Length; i++)
                {
                    poleCisel[i] = i;
                }
                
                for (int i = 0; i < poleCisel.Length; i++)
                {
                    Console.WriteLine(poleCisel[i]);
                }
                */

                for (int i = 0; i < pocet; i++)
                {
                    Console.WriteLine("Zadej cislo 1");
                    float cislo1 = Convert.ToSingle(Console.ReadLine());

                    Console.WriteLine("Zadej cislo 2");
                    float cislo2 = Convert.ToSingle(Console.ReadLine());

                    Console.WriteLine("Zadej operaci (+ - * /)");
                    string operace = Console.ReadLine();

                    if (operace != "+" && operace != "-" && operace != "*" && operace != "/")
                        //if(operace == "+" || operace == "-" || operace == "*" || operace == "/")
                        Console.WriteLine("Zadali jste spatny typ operace !!!");
                    else
                        Console.WriteLine("Vysledek operace cisel je " + SpocitejVysledek(cislo1, cislo2, operace));
                }

                Console.WriteLine("Konec aplikace");
            }
            catch 
            {
                Console.WriteLine("Nezadali jste cislo, nashle");
            }
           
            Console.ReadLine();
        }

        static float SpocitejVysledek(float number1, float number2, string operation) 
        {
            float vysledek;

            switch (operation)
            {
                case "+":
                    vysledek = number1 + number2;
                    break;
                case "-":
                    vysledek = number1 - number2;
                    break;
                case "*":
                    vysledek = number1 * number2;
                    break;
                case "/":
                    vysledek = number1 / number2;
                    break;
                default:
                    vysledek = int.MinValue;
                    break;
            }

            return vysledek;
        }
    }
}
