using System;

namespace Vehicles
{
    public class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double fuelConsumptionInLitersPerKm, double tankCapacity) : base(fuelQuantity, fuelConsumptionInLitersPerKm, tankCapacity)
        {
        }

        public override double FuelConsumptionInLitersPerKm => base.FuelConsumptionInLitersPerKm + 1.6;

        public override void Refuel(double liters)
        {
            if (liters <= 0)
                throw new ArgumentException("Fuel must be a positive number");

            if (!CanRefuel(liters))
                throw new InvalidOperationException($"Cannot fit {liters} fuel in the tank");

            liters *= 0.95;
            base.Refuel(liters);
        }
    }
}