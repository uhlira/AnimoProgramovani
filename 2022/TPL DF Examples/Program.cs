using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace TPL_DF_Examples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a BroadcastBlock<double> object.
            var broadcastBlock = new BroadcastBlock<double>(null);

            // Post a message to the block.
            broadcastBlock.Post(Math.PI);

            // Receive the messages back from the block several times.
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(broadcastBlock.Receive());
            }

            // Post a message to the block.
            broadcastBlock.Post(Math.PI- 1);

            // Receive the messages back from the block several times.
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(broadcastBlock.Receive());
            }

            /* Output:
               3.14159265358979
               3.14159265358979
               3.14159265358979
             */

            Console.ReadKey();

            /* Output:
            n = 0
            n = -1
            Encountered ArgumentOutOfRangeException: Specified argument was out of the range
             of valid values.
            */
        }
    }
}
