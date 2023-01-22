namespace NeedForSpeed
{
    public class Vehicle
    {
        private const double DEFAULT_FUEL_CONSUMPTION = 1.25;

        public Vehicle(int horsePower, double fuel)
        {
            Fuel = fuel;
            HorsePower = horsePower;
        }

        public double Fuel { get; set; }
        public int HorsePower { get; set; }
        public virtual double FuelConsumption => DEFAULT_FUEL_CONSUMPTION;
        public virtual void Drive(double kilometers)
        {
            double fuelLeft = Fuel - FuelConsumption * kilometers;

            if (fuelLeft >= 0)
            {
                Fuel = fuelLeft;
            }
        }
    }
}