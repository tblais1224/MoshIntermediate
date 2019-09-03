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
        }
    }
}
