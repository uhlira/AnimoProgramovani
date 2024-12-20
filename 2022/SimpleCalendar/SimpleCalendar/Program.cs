using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalendar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Record> events = new List<Record>();

            //Console.WriteLine(Directory.GetCurrentDirectory());

            string path = Path.Combine(Directory.GetCurrentDirectory(), "Diary.txt");
            string diary = string.Empty;

            Console.WriteLine("Aktuální obsah diáře: ");

            if (File.Exists(path))
            {
                diary = File.ReadAllText(path);
                //Console.WriteLine(diary);

                foreach (string line in diary.Split(Environment.NewLine.ToCharArray())) 
                {
                    if (line != string.Empty) 
                    {
                        string[] record = line.Split('#');
                        Record r = new Record
                        {
                            dt = DateTime.Parse(record[0]),
                            content = record[1]
                        };
                        events.Add(r);
                        Console.WriteLine(r.dt + "\t" + r.content);
                    } 
                }
            }
            else 
            {
                File.Create(path);
            }

            Console.InputEncoding = System.Text.Encoding.Unicode;

            string command = string.Empty;
            /*
            Record r = new Record();
            r.dt = DateTime.Now;
            r.content = "Zubař";
            */
            try
            {
                Console.WriteLine("Zadejte čas události nebo ukončete příkazem EXIT: ");
                while ((command = Console.ReadLine()) != "EXIT")
                {
                    Record r = new Record();
                    r.dt = DateTime.Parse(command);

                    Console.WriteLine("Zadejte obsah události: ");
                    r.content = Console.ReadLine();
                    events.Add(r);

                    Console.WriteLine("Zadejte čas události nebo ukončete příkazem EXIT: ");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Chyba!!! - " + e.Message);
            }

            string s = string.Empty;
            foreach (Record r in events) 
            {
                s += r.dt + "#" + r.content + Environment.NewLine;
            }
            
            Console.WriteLine(s);

            try
            {
                File.WriteAllText(path, s);
            }
            catch (Exception e)
            {
                Console.WriteLine("Chyba!!! - " + e.Message);
            }

            Console.WriteLine("Konec");
            Console.ReadLine();
        } 
    }

    public struct Record
    {
        public DateTime dt;
        public string content;
    }
}
