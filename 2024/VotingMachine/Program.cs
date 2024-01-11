using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many parties would you like to vote for?");
            int count = 0;//Precteni poctu stran od uzivatele

            string[] parties = new string[count];

            for (int i = 0; i < count; i++)
            {
                //postupne nacteni jmen a ulozeni do pole
                parties[i] = "";
            }


            #region Voting
            /*
            List<string> votes = new List<string>();

            votes.Add("ANO");
            votes.Add("TOP09");
            votes.Add("ANO");

            int ano = 0;
            int top09 = 0;
            foreach (string vote in votes)
            {
                if (vote == "ANO") ano++;
                if (vote == "TOP09") top09++;
            }

            
            Console.WriteLine("Election 2023");
            Console.WriteLine("Please, select party");
            PrintParties(parties);

            string votetext = Console.ReadLine();
            while (votetext != "end")
            {
                int voteint = Convert.ToInt32(votetext);
                votes[voteint] = voteint;

                PrintParties(parties);
                Console.WriteLine("Please, select party");
                votetext = Console.ReadLine();

                if (votetext == "end")
                {
                    Console.WriteLine("Vote count: " + parties.Length);
                }
            }

            Console.WriteLine("Election ended");
            */
            #endregion

            Console.ReadKey();
        }

        static void PrintParties(string[] parties) 
        {
            for (int i = 0; i < parties.Length; i++)
            {
                Console.WriteLine(i + " : " + parties[i]);
            }
        }
        static void PrintVotes(int[] votes, string[] parties)
        {
            for (int i = 0; i < votes.Length; i++)
            {
                Console.WriteLine(parties[i] + " : " + votes[i]);
            }
        }

    }
}
