using System;

namespace MoshIntermediate
{
    public abstract class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        //use abstract so an error is thrown if a class inheriting Shape does not implement logic for the draw method
        public abstract void Draw();

        public void Copy()
        {
            Console.WriteLine("copy shape to clipboard");
        }
        public void Select()
        {
            Console.WriteLine("select the shape");
        }
    }
}