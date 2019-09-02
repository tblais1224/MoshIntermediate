using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshIntermediate
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            //tested ten second timer
            do
            {
                Console.WriteLine(stopwatch.Stop());
            } while (stopwatch.Stop() < TimeSpan.FromSeconds(10));

        }
    }
}
