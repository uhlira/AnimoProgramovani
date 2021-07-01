using System;
using System.Collections.Generic;

namespace Kalkulacka
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> intList = new List<int>();

                Console.WriteLine("Vítejte v kalkulačce");
                
                Console.WriteLine("Zadávejte čísla, až do zadání C:");

                /*
                int count = int.Parse(Console.ReadLine());
                
                int[] array = new int[count];
                */
                /*
                for (int i = 0; i < count; i++) 
                {
                    Console.WriteLine("Zadejte číslo {0}:", i);
                    //array[i] = int.Parse(Console.ReadLine());
                    intList.Add(int.Parse(Console.ReadLine()));
                }
                */

                do
                {
                    Console.WriteLine("Zadejte číslo:");

                    string s = Console.ReadLine();
                    if (s == "C") break;

                    intList.Add(int.Parse(s));
                }
                while (true);
                

                Console.WriteLine(
                    "Zadejte operaci: " 
                    + Environment.NewLine
                    + "1: Average"
                    + Environment.NewLine
                    + "2: Sum"
                    + Environment.NewLine
                    + "3: Min"
                    + Environment.NewLine
                    + "4: Max"
                    );
                int operation = int.Parse(Console.ReadLine());

                float result;
                switch (operation) 
                {
                    case 1: result = GetAverage(intList.ToArray());
                        break;

                    case 2:
                        result = GetSum(intList.ToArray());
                        break;

                    case 3:
                        result = GetMin(intList.ToArray());
                        break;

                    case 4:
                        result = GetMax(intList.ToArray());
                        break;

                    default: result = 0;
                        break;
                }

                Console.WriteLine("Výsledek: " + Math.Round(result, 2));
            }
            catch (Exception e)
            {
                Console.WriteLine("Chybně zadané číslo!");
            }
        }

        public static float GetAverage(int[] array) 
        {
            float avg = 0;

            for (int i = 0; i < array.Length; i++) 
            {
                avg += array[i];
            }

            return avg/array.Length;
        }

        public static float GetSum(int[] array)
        {
            float sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            return sum;
        }

        public static float GetMin(int[] array)
        {
            float min = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min) min = array[i];
            }

            return min;
        }

        public static float GetMax(int[] array)
        {
            float max = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max) max = array[i];
            }

            return max;
        }
    }
}
