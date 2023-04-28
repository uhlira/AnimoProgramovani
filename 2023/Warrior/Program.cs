using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Hra Warrior

Hra predstavuje bojovnika ktery ma Health, na zacatku vzdy 100%
Na tohoto bojovnika utocime pomoci hraci kostky a on nam udery vraci
Prvni kdo protivnikovi ubere zdtravi do 0 -> VYHRAVA
 
 */

namespace Warrior
{
    internal class Program
    {
        static Random random = new Random();
        static void Main(string[] args)
        {
            int Warrior = 100;
            int Player = 100;

            while (Warrior > 0 && Player > 0)
            {
                int Attack = RollDice();
                Warrior = Warrior - Attack;
                Warrior -= Attack;
                Console.WriteLine("Warrior health: " + PrintHealth(Warrior)) ;
            }

            Console.ReadLine();
        }

        static int RollDice() 
        {
            return random.Next(1, 7);
        }

        /*
         *
        Warrior health: [######    ]
         */
        static string PrintHealth(int health)
        {
            /*
            string shealth = "[";
            for (int i = 0; i < 10; i++) 
            {
                if (health > i*10)
                {
                    shealth += "#";
                }
                else shealth += " ";
            }
            shealth += "]";
            */

            string shealth = "[";
            for (int i = 0; i < health; i = i + 10)
            {
                shealth += "#";
            }
            shealth += "]";

            return shealth;
        }
    }
}
