using System;
using System.Text;

namespace Shapes
{
    public class Rectangle : Shape
    {
        private double height;
        private double width;

        public Rectangle(double height, double width)
        {
            this.height = height;
            this.width = width;
        }

        public override double CalculateArea() => this.height * this.width;
        public override double CalculatePerimeter() => 2 * (this.height + this.width);
        public override string Draw()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(new string('*', (int)width));
            for (int i = 1; i < this.height - 1; i++)
            {
                sb.Append('*');
                sb.Append(new string(' ', (int)width - 2));
                sb.AppendLine("*");
            }
            sb.Append(new string('*', (int)width));

            return sb.ToString().TrimEnd();
        }
    }
}