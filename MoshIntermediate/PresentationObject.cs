using System;

namespace MoshIntermediate
{
    public class PresentationObject
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public void Copy()
        {
            Console.WriteLine("object copied to clipboard");
        }

        public void Duplicate()
        {
            Console.WriteLine("Object was duplicated");
        }
    }
}