using System;
using System.IO;
using System.Linq;

/*
Program načte seznam stran ze souboru a vypise ho
Potom se cyklicky pta jakou stranu chceme zvolit
Po zadani END volby konci a vypisou se vysledky
 */

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
            string[] parties = new string[] { "ANO", "TOP095614145814", "ODS", "Piráti" };


















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

            for (int i = 0; i < votes.Length; i++)
            {
                Console.WriteLine(
                    "Strana "
                    + parties[i]
                    + " získala "
                    + Math.Round(((float)votes[i] / votes.Sum()) * 100, 2) + " %"
                    + "  "
                    + votes[i] + "/" + votes.Sum()
                    + " hlasů"
                    );
            }

            Console.WriteLine();
            for (int i = 0; i < votes.Length; i++)
            {   //parties.Max(x => x.Length) + 5
                Console.Write(parties[i] + "".PadLeft(10 - parties[i].Length));
                string s = "";
                for (int j = 0; j < votes[i]; j++)
                {
                    s += "*";
                }
                Console.WriteLine(s);
            }


            Console.ReadKey();
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
