using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        /*
        static void Main(string[] args)
        {
            int count = -1;
            Console.ForegroundColor = ConsoleColor.Green;

            while (true)
            {
                try
                {
                    Console.WriteLine("Tell me count of your classmates");
                    count = Convert.ToInt32(Console.ReadLine());
                    break;  
                }
                catch (Exception)
                {
                    Console.WriteLine("You are fool, try again");
                }    
            }

            Console.WriteLine("The count of my classmates is " + count);

            Console.ReadKey();
        }
        */

        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("Tell me count of grades");
            int count = Convert.ToInt32(Console.ReadLine());

            int[] grades = new int[count];

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Tell me grade " + i);
                int grade = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Grade " + i + " is " + grade);
                sum = sum + grade;
                grades[i] = grade;
            }

            double dsum = sum;
            double avg = dsum / count;

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Grade " + i + "= " + grades[i]);
            }


            Console.WriteLine("Sum of grades is " + sum + " " + avg);
            //Console.WriteLine("Average of grades is " +);

            Console.ReadKey();
        }
    }
}
