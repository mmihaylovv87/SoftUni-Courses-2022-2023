using System;

namespace _01._Shapes
{
    public class Rectangle : IDrawable
    {
        public Rectangle(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }

        public int Width { get; private set; }
        public int Height { get; private set; }

        public void Draw()
        {
            for (int i = 0; i < this.Height; i++)
                Console.WriteLine(new string('*', this.Width));
        }

        public void DrawShape()
        {
            Console.WriteLine(new string('*', this.Width * 2));

            for (int i = 0; i < this.Height - 2; i++)
                Console.WriteLine('*' + new string(' ', this.Width * 2 - 2) + '*');

            Console.WriteLine(new string('*', this.Width * 2));
        }

        public override string ToString() => $"Rectangle with width {this.Width} and height {this.Height}";
    }
}