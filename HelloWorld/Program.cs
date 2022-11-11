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
            Console.WriteLine("Zadej jmeno: ");
            string name = Console.ReadLine();

            Console.WriteLine("Zadej prijmeni: ");
            string surname = Console.ReadLine();

            Console.WriteLine("Zadej vek: ");
            string agestring = Console.ReadLine();
            int age = Convert.ToInt32(agestring);

            Console.WriteLine("Ahoj " + name + " " + surname + ", je ti " + age + " let");
            Console.WriteLine("Za 10 let ti bude " + (age + 10)  + " let");

            Console.ReadKey();
        }
    }
}

/*
            int number1 = 10;
            int number1 = 5;

            if (number1 > number2)
            {

            }
            else 
            {
            
            }
            */
