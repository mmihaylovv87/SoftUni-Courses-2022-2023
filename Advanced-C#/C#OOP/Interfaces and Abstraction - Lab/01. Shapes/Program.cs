using System;
using System.Collections.Generic;

namespace _01._Shapes
{
    public class Program
    {
        static void Main()
        {
            List<IDrawable> shapes = new List<IDrawable>();
            shapes.Add(new Circle(7));
            shapes.Add(new Square(7));
            shapes.Add(new Rectangle(9, 5));
            shapes.Add(new Square(9));
            shapes.Add(new Circle(11));

            foreach (var shape in shapes)
            {
                Console.WriteLine(shape.ToString());
                shape.DrawShape();
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}