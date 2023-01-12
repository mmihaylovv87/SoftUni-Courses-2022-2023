using System.Text;

namespace SixthExercise
{
    public class Vehicle
    {
        public Vehicle(string vehicleType, string model, string color, int horsepower)
        {
            this.Type = vehicleType;
            this.Model = model;
            this.Color = color;
            this.Horsepower = horsepower;
        }

        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Horsepower { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Type: {this.Type}");
            sb.AppendLine($"Model: {this.Model}");
            sb.AppendLine($"Color: {this.Color}");
            sb.AppendLine($"Horsepower: {this.Horsepower}");
            return sb.ToString().TrimEnd();
        }
    }
}