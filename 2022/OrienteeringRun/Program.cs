using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrienteeringRun
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string CorrectResult = "ABCD";
            string RealResult = "ACBD";

            char lastCorrectChar = '_';
            int lastCorrectIndex = -1;
            int lastCorrectIndexer = CorrectResult.Length - 1;

            char comparingChar = '_';
            int comparingIndex = -1;

            int faultCount = -1;

            do
            {
                lastCorrectChar = CorrectResult[lastCorrectIndexer];
                lastCorrectIndex = RealResult.LastIndexOf(CorrectResult[lastCorrectIndexer]);

                faultCount++;
            }
            while (lastCorrectIndex < 0 && lastCorrectIndexer-- > 0);

            Console.Write(lastCorrectChar);

            faultCount += RealResult.Length - lastCorrectIndex - 1;

            for (int j = lastCorrectIndex - 1; j >= 0; j--)
            {
                int k = j;
                int l = 0;
                
                while ((RealResult[k--] != CorrectResult[lastCorrectIndexer - 1]) && k >= 0)
                {
                    l++;
                }

                if (k < -1)
                {
                    faultCount++;

                    lastCorrectIndexer = j;
                    do
                    {
                        lastCorrectChar = CorrectResult[lastCorrectIndexer];
                        lastCorrectIndex = RealResult.LastIndexOf(CorrectResult[lastCorrectIndexer]);

                        faultCount++;
                    }
                    while (lastCorrectIndex < 0 && lastCorrectIndexer-- > 0);
                }
                else 
                {
                    if ((RealResult[k+1] == CorrectResult[lastCorrectIndexer - 1]))
                    {
                        comparingChar = RealResult[k + 1];
                        comparingIndex = k + 1;

                        Console.Write(comparingChar);
                    }

                    j -= l;
                    lastCorrectIndexer--;

                    faultCount += l;
                } 
            }

            Console.WriteLine();
            Console.WriteLine("Fault count: " + faultCount);
            Console.ReadKey();

        }
    }
}
