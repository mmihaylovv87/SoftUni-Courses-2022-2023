using System;

namespace _01._Shapes
{
    public class Circle : IDrawable
    {
        public Circle(int radius)
        {
            this.Radius = radius;
        }

        public int Radius { get; }

        public void Draw()
        {
            for (int i = 0; i < this.Radius * 2; i++)
            {
                for (int j = 0; j < this.Radius * 2; j++)
                {
                    var distance = Math.Sqrt((this.Radius - i) * (this.Radius - i) + (this.Radius - j) * (this.Radius - j));
                    if (Math.Ceiling(distance) <= this.Radius)
                        Console.Write('*');
                    else
                        Console.Write(' ');
                }
                Console.WriteLine();
            }
        }

        public void DrawShape()
        {
            for (int i = 0; i < this.Radius * 2; i++)
            {
                for (int j = 0; j < this.Radius * 2; j++)
                {
                    var distance = Math.Sqrt((this.Radius - i) * (this.Radius - i) + (this.Radius - j) * (this.Radius - j));
                    if (Math.Ceiling(distance) == this.Radius)
                        Console.Write('*');
                    else
                        Console.Write(' ');
                }
                Console.WriteLine();
            }
        }

        public override string ToString() => $"Circle with radius {this.Radius}";
        
    }
}