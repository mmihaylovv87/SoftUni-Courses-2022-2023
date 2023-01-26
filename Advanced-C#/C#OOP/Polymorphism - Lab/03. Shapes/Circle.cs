using System;
using System.Text;

namespace Shapes
{
    public class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double CalculateArea() => Math.PI * this.radius * this.radius;
        public override double CalculatePerimeter() => 2 * Math.PI * this.radius;
        public override string Draw()
        {
            double consoleRatio = Convert.ToDouble(4.0 / 2.0);
            double a = consoleRatio * this.radius;
            double b = this.radius;

            StringBuilder sb = new StringBuilder();
            for (double y = -radius; y <= radius; y++)
            {
                for (double x = -a; x <= a; x++)
                {
                    double d = (x / a) * (x / a) + (y / b) * (y / b);
                    if (d > 1 && d < 1.2)
                        sb.Append('*');
                    else
                        sb.Append(" ");
                }
                sb.AppendLine();
            }
            return sb.ToString().TrimEnd();
        }
    }
}