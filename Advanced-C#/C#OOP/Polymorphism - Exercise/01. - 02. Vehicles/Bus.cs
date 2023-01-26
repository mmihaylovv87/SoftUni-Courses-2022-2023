namespace Vehicles
{
    public class Bus : Vehicle
    {
        public Bus(double fuelQuantity, double fuelConsumptionInLitersPerKm, double tankCapacity) : base(fuelQuantity, fuelConsumptionInLitersPerKm, tankCapacity)
        {
        }

        public override double FuelConsumptionInLitersPerKm => this.IsEmpty ? base.FuelConsumptionInLitersPerKm : base.FuelConsumptionInLitersPerKm + 1.4;
    }
}