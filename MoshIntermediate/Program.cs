using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoshIntermediate
{
    public class Person
    {
        private DateTime _bithdate;

        public void SetBirthdate(DateTime birthdate)
        {
            _bithdate = birthdate;
        }

        public DateTime GetBirthdate()
        {
            return _bithdate;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.SetBirthdate(new DateTime(1996, 1, 12));
            Console.WriteLine(person.GetBirthdate());
        }
    }
}
