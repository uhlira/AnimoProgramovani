using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAnalysis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Dictionary<string, int> Histogram = new Dictionary<string, int>();

            string text = File.ReadAllText("HarryPotterUryvekUpravene.txt"); 
            string[] words = text.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < words[i].Length; j++)
                {
                    if (!Char.IsLetterOrDigit(words[i][j]))
                    {
                        words[i] = words[i].Remove(j--, 1);
                    }
                }  
            }

            foreach (string word in words)
            {
                string tmpword = word.Trim();
                if (!Histogram.ContainsKey(tmpword))
                {
                    Histogram.Add(tmpword, Count(text, tmpword));
                }
            }

            foreach (KeyValuePair<string, int> kvp in Histogram)
            {
                Console.WriteLine(kvp.Key.PadRight(20) + kvp.Value);
            }

            Console.ReadKey();
        }

        static int Count(string text, string substring) 
        {
            int i = 0;
            while (text.Contains(substring))
            {
                text = text.Remove(0, text.IndexOf(substring) + substring.Length);
                i++;
            }
            
            return i;
        }
    }
}
