using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            //IntList list = new IntList();
            List<int> list = new List<int>();
            list.remo

            list.Add(55);
            list.Add(56);
            list.Add(57);
            list.Remove();

            list.Add(58);
            list.Add(59);
            list.Add(60);
            list.Remove();

            list.Reverse();

            Console.WriteLine(list.Contains(58) + " " + list.Contains(61));

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }


            Console.ReadKey();
        }
    }
}
