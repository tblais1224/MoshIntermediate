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
            var person = new Person(new DateTime(1996, 1, 12));
            Console.WriteLine(person.Age);
        }
    }
}
