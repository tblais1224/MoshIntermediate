using System;

namespace MoshIntermediate
{
    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a Circle");
        }
    }

    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a Rectangle");
        }
    }
    public class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a Triangle");
        }
    }
    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Position Position { get; set; }

        //virtual lets the method be modified
        public virtual void Draw()
        {

        }

    }
}