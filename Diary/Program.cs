using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diary
{
    class Program
    {
        static Dictionary<string, string> users = CreateUsers();
        static string loggedUser = string.Empty;

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Diary diary = new Diary();
            DiaryAction action = DiaryAction.EXIT_APP;

            try
            {
                do
                {
                    PrintMenu();

                    action = ReadMenuKey();
                    Console.Clear();
                    PrintMenu();

                    Console.WriteLine();

                    switch (action)
                    {
                        case DiaryAction.ADD_RECORD:
                            diary.Add(PrintAddRecord());
                            Console.WriteLine("Záznam úspěšně přidán.");
                            Console.ReadKey();
                            break;
                        case DiaryAction.PRINT_RECORDS:
                            {
                                foreach (Record r in diary.Records)
                                {
                                    Console.WriteLine(r.ToString());
                                }
                            }
                            Console.ReadKey();
                            break;
                        case DiaryAction.SAVE_DIARY:
                            diary.Save();
                            Console.WriteLine("Diář úspěšně uložen.");
                            Console.ReadKey();
                            break;
                        case DiaryAction.LOAD_DIARY:
                            diary.Load();
                            Console.WriteLine("Diář úspěšně načten.");
                            Console.ReadKey();
                            break;
                        case DiaryAction.LOG_IN:
                            {
                                string username = PrintLogin();
                                if (username != string.Empty) 
                                {
                                    loggedUser = username;
                                    Console.WriteLine($"Uživatel {username} úspěšně přihlášen.");
                                }
                                else Console.WriteLine($"Špatné heslo");

                                Console.ReadKey();
                            }
                            break;
                        default:
                            break;
                    }

                    Console.Clear();
                } while (action != DiaryAction.EXIT_APP);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
            //Console.ReadKey();
        }

        public static void PrintMenu() 
        {
            Console.WriteLine("DIARY MENU");
            Console.WriteLine("1 - ADD RECORD");

            Console.WriteLine("3 - PRINT RECORDS");

            Console.WriteLine("4 - SAVE DIARY");
            Console.WriteLine("5 - LOAD DIARY");

            Console.WriteLine("6 - LOG IN");

            Console.WriteLine("0 - EXIT APP");
        }

        public static DiaryAction ReadMenuKey()
        {
            switch (Console.ReadKey().KeyChar) 
            {
                case '1': return DiaryAction.ADD_RECORD;
                case '2': return DiaryAction.REMOVE_RECORD;

                case '3': return DiaryAction.PRINT_RECORDS;

                case '4': return DiaryAction.SAVE_DIARY;
                case '5': return DiaryAction.LOAD_DIARY;

                case '6': return DiaryAction.LOG_IN;

                case '0': return DiaryAction.EXIT_APP;

                default: return DiaryAction.PRINT_RECORDS;
            }
        }

        public enum DiaryAction 
        {
            ADD_RECORD, 
            PRINT_RECORDS, 
            SAVE_DIARY, 
            LOAD_DIARY,
            EXIT_APP, 
            REMOVE_RECORD, 
            LOG_IN
        }

        public static Record PrintAddRecord()
        {
            Record r = new Record() { RecordTime = DateTime.Now };

            Console.Write("Autor: ");
            //r.Autor = Console.ReadLine();
            Console.WriteLine(Console.ReadLine());

            Console.Write("Title: ");
            r.Title = Console.ReadLine();

            Console.Write("Text: ");
            r.Text = Console.ReadLine();

            return r;
        }

        public static string PrintLogin()
        {
            Console.Write("Username: ");
            string username = Console.ReadLine();

            Console.Write("Password: ");
            string password = Console.ReadLine();

            if (password == users[username])
            {
                return username;
            }
            else return string.Empty;

            //return password == users[username] ? username : string.Empty;
        }

        public static Dictionary<string, string> CreateUsers() 
        {
            Dictionary<string, string> users = new Dictionary<string, string>();
            users.Add("Adam", "animo");
            users.Add("Lojza", "zamberk");
            users.Add("David", "letohrad");

            return users;
        }
    }
}
