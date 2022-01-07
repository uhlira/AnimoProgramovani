using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diary
{
    class Program
    {
        static void Main(string[] args)
        {
            Diary diary = new Diary();
            DiaryAction action = DiaryAction.EXIT_APP;

            do
            {
                PrintMenu();

                action = ReadMenuKey();

                switch (action)
                {
                    case DiaryAction.ADD_RECORD: diary.Add(PrintAddRecord());
                        break;
                    case DiaryAction.PRINT_RECORDS:
                        {
                            foreach (Record r in diary.Records)
                            {
                                Console.WriteLine(r.ToString());
                            }
                        }
                        break;
                    case DiaryAction.SAVE_DIARY:
                        break;
                    default:
                        break;
                }

                Console.ReadKey();
                Console.Clear();
            } while (action != DiaryAction.EXIT_APP);

            //Console.ReadKey();
        }

        public static void PrintMenu() 
        {
            Console.WriteLine("DIARY MENU");
            Console.WriteLine("1 - ADD RECORD");
            Console.WriteLine("2 - PRINT RECORDS");
            Console.WriteLine("3 - SAVE DIARY");

            Console.WriteLine("0 - EXIT APP");
        }

        public static DiaryAction ReadMenuKey()
        {
            switch (Console.ReadKey().KeyChar) 
            {
                case '1': return DiaryAction.ADD_RECORD;
                case '2': return DiaryAction.PRINT_RECORDS;
                case '3': return DiaryAction.SAVE_DIARY;

                case '0': return DiaryAction.EXIT_APP;

                default: return DiaryAction.PRINT_RECORDS;
            }
        }

        public enum DiaryAction 
        {
            ADD_RECORD, 
            PRINT_RECORDS, 
            SAVE_DIARY, 
            EXIT_APP
        }

        public static Record PrintAddRecord()
        {
            Record r = new Record() { RecordTime = DateTime.Now };

            Console.Write("Autor: ");
            r.Autor = Console.ReadLine();

            Console.Write("Title: ");
            r.Title = Console.ReadLine();

            Console.Write("Text: ");
            r.Text = Console.ReadLine();

            return r;
        }
    }
}
