using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolebniPristroj
{
    class Program
    {
        static string FILENAME = @"SeznamStran.txt";

        static void Main(string[] args)
        {
            Console.WriteLine("Vítejte u voleb 2021");

            Console.WriteLine("Můžete vybírat z těchto stran");

            //string[] parties = LoadParties(FILENAME);  
            string[] parties = new string[] { "ANO" };
            if (parties != null)
            {
                PrintParties(parties);
            }

            int[] votes = new int[parties.Length];

            Console.WriteLine("Přejete si upravit seznam stran? A/N");
            if (Console.ReadLine().ToUpper() == "A") 
            {
                //tady bude kod pro editaci seznamu stran
            }

            while (true)           
            {
                Console.WriteLine("Zvolte stranu:");

                PrintParties(parties);
                Console.WriteLine("Pro ukončení voleb zadejte \"END\"");

                string choice = Console.ReadLine();
                try
                {
                    int ichoice = Convert.ToInt32(choice);
                    if (ichoice < parties.Length)
                    {
                        votes[ichoice]++;
                    }
                    else Console.WriteLine("Zadali jste moc vysoké číslo - taková strana neexistuje");
                }
                catch
                {
                    if (choice.ToUpper() == "END") break;
                    else Console.WriteLine("Nezadali jste číslo");
                }
            }
        }

        static bool SaveParties(string path, string[] parties)
        {
            try
            {
                if (!File.Exists(path))
                {
                    File.Create(path);
                }

                File.WriteAllText(path, string.Join("#", parties));
                return true;
            }
            catch
            {
                return false;
            }
        }

        static string[] LoadParties(string path)
        {
            try
            {
                if (!File.Exists(path))
                {
                    return null;
                }

                string[] s = File.ReadAllText(path).Split('#');
                return s.Length == 0 ? null : s;
            }
            catch
            {
                return null;
            }
        }

        static void PrintParties(string[] parties) 
        {
            for (int i = 0; i < parties.Length; i++)
            {
                Console.WriteLine("{0}: {1}", i, parties[i]);
            }
        }
    }
}
