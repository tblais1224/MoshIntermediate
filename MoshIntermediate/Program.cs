using System;
using System.Collections;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace MoshIntermediate
{
    class Program
    {
        static void Main(string[] args)
        {
            //my stack code
            var stack = new Stack();
            stack.Push(22);
            stack.Push(true);
            stack.Push("hi tom");
            stack.Push(331544524);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            stack.Clear();
            //throws error handle
            //stack.Pop();



            //mosh stack code
            var moshStack = new MoshStack();

            int ini = 0;
            int max = 5;

            for (int i = ini; i <= max; i++)
            {
                moshStack.Push(i);
            }

            for (int i = ini; i <= max; i++)
            {
                Console.WriteLine(moshStack.Pop());
            }

            Console.ReadLine();
        }
    }
}
