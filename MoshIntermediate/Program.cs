using System;
using System.Collections;
using System.Collections.Generic;
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
            //Text text = new Text();
            //Shape shape = text;

            //text and shape point to the same object
            //text.Width = 200;
            //shape.Width = 100;

            //Console.WriteLine(text.Width);




            //StreamReader reader = new StreamReader(new MemoryStream());

            //array list is not type sensitive
            //var list = new ArrayList();
            //list.Add(1);
            //list.Add("tom");
            //list.Add(new Text());

            //creates a list of Shapes only
            //var anotherList = new List<Shape>();




            Shape shape = new Text();
            Text text = (Text) shape;
            //now with text object all methods   class available
        }
    }
}
