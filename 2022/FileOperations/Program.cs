using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "test.txt";
            string[] sarr = new string[]
            {
                "TOP09",
                "ANO",
                "ODS",
                "ČSSD"
            };

            if (WriteTextInFile(sarr, path, "#")) 
            {
                Console.WriteLine("Zápis do souboru se zdařil");
            }
            else Console.WriteLine("Zápis do souboru se nezdařil");

            Console.WriteLine("Obsah souboru " + path + ":");
            string content = (ReadTextInFile(path));
            Console.WriteLine(content);

            Console.WriteLine("Načtené politické strany: ");
            string[] sarr2 = content.Split('#');
            for (int i = 0; i < sarr2.Length; i++)
            {
                Console.Write(sarr2[i] + " ");
            }


            Console.WriteLine();

            Task tw = ReadAsyncFile(path);
            tw.Wait();
            //stream.Flush();
            stream.Position = 0;

            byte[] buffer2 = new byte[sizeof(int) * 1000];
            Task<int> tr = stream.ReadAsync(buffer2, 0, 4000);
            tr.Wait();
            Console.WriteLine(tr.Result);
            return Encoding.ASCII.GetString(buffer2);

            await ReadAsyncFile(path);
            Console.ReadKey();
        }

        static bool WriteTextInFile(int[] integers, string path, string delimiter)
        {
            string[] texts = new string[integers.Length];
            for (int i = 0; i < integers.Length; i++)
            {
                texts[i] = integers[i].ToString();
            }
            return WriteTextInFile(texts, path, delimiter);
        }

        static bool WriteTextInFile(string[] texts, string path, string delimiter)
        {
            return WriteTextInFile(string.Join(delimiter, texts), path);
        }

        static bool WriteTextInFile(string text, string path) 
        {
            try
            {
                File.WriteAllText(path, text);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        static string ReadTextInFile(string path)
        {
            try
            {
                return File.ReadAllText(path);
            }
            catch
            {
                return string.Empty;
            }
        }

        static Task WriteAsyncFile(string path)
        {
            using (FileStream stream = File.Create(path))
            {
                string buffer1 = "";
                for (int i = 0; i < 1000; i++)
                {
                    buffer1 += new Random().Next(0, 9);
                }
                return stream.WriteAsync(Encoding.ASCII.GetBytes(buffer1), 0, sizeof(byte)*buffer1.Length);
            }
        }

        static async string ReadAsyncFile(Task t)
        {
                t.Wait();
            /*
                 string buffer1 = "";
                 for (int i = 0; i < 1000; i++)
                 {
                     buffer1 += new Random().Next(0, 9);
                 }
                 return stream.WriteAsync(Encoding.ASCII.GetBytes(buffer1), 0, sizeof(byte) * buffer1.Length);
            */
            return t;
            }
        }
    }
}
