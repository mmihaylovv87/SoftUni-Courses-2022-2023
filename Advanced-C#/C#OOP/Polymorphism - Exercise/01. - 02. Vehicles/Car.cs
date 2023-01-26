namespace Vehicles
{
    public class Car : Vehicle
    {
        public Car(double fuelQuantity, double fuelConsumptionInLitersPerKm, double tankCapacity) : base(fuelQuantity, fuelConsumptionInLitersPerKm, tankCapacity)
        {
        }

        public override double FuelConsumptionInLitersPerKm => base.FuelConsumptionInLitersPerKm + 0.9;
    }
}