using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MoshIntermediate
{
    class Program
    {
        static void Main(string[] args)
        {
            //my code

            //var stopwatch = new Stopwatch();
            //stopwatch.Start();

            ////tested ten second timer
            //do
            //{
            //    Console.WriteLine(stopwatch.Stop());
            //} while (stopwatch.Stop() < TimeSpan.FromSeconds(10));



            // mosh stopwatch review code
            var moshStopwatch = new MoshStopwatch();

            for (int i = 0; i < 2; i++)
            {
                moshStopwatch.Start();
                Thread.Sleep(1000);

                moshStopwatch.Stop();

                Console.WriteLine("Duration: " + moshStopwatch.GetInterval().ToString());

                Console.WriteLine("Press enter to run the stopwatch once more.");

                Console.ReadLine();
            }
        }
    }
}
