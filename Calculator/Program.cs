using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Vítejte v kalkulačce");
                MyCalculator calc = new MyCalculator();
                double result = 0;
                double num1 = 0;
                double num2 = 0;

                while (true)
                {
                    Console.WriteLine(
                            "Zadejte operaci: "
                            + Environment.NewLine
                            + "1: Součet"
                            + Environment.NewLine
                            + "2: Rozdíl"
                            + Environment.NewLine
                            + "3: Násobení"
                            + Environment.NewLine
                            + "4: Dělení"
                            + Environment.NewLine
                            + "5: Konec"
                            + Environment.NewLine
                            + "6: M+"
                            + Environment.NewLine
                            + "7: M-"
                            + Environment.NewLine
                            + "8: MR"
                            + Environment.NewLine
                            + "9: MC"
                            );
                    int operation = int.Parse(Console.ReadKey().KeyChar.ToString());
                    Console.WriteLine();


                    if (operation == 5)
                    {
                        break;
                    }

                    string outputString = string.Empty;

                    if (operation >= 1 && operation <= 4)
                    {
                        Console.Write("Zadej cislo 1: ");
                        num1 = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Zadej cislo 2: ");
                        num2 = Convert.ToDouble(Console.ReadLine());
                    }

                    switch (operation)
                    {
                        case 1:
                            result = calc.Add(num1, num2);
                            outputString = "Výsledek: " + Math.Round(result, 2);
                            break;

                        case 2:
                            result = calc.Subtract(num1, num2);
                            outputString = "Výsledek: " + Math.Round(result, 2);
                            break;

                        case 3:
                            result = calc.Multiply(num1, num2);
                            outputString = "Výsledek: " + Math.Round(result, 2);
                            break;

                        case 4:
                            result = calc.Divide(num1, num2);
                            outputString = "Výsledek: " + Math.Round(result, 2);
                            break;

                        case 6:
                            calc.MemoryAdd(result);
                            break;

                        case 7:
                            calc.MemorySubtract(result);
                            break;

                        case 8:
                            outputString = "Obsah paměti je " + calc.MemoryRecall();
                            break;

                        case 9:
                            calc.MemoryClear();
                            break;

                        default:
                            result = 0;
                            break;

                    }

                    Console.WriteLine(outputString);
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + Environment.NewLine + e.StackTrace);
                Console.ReadKey();
            }
           
        }
    }
}
