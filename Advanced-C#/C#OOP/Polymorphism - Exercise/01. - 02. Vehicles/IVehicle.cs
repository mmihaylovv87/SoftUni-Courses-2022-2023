namespace Vehicles
{
    public interface IVehicle
    {
        public double FuelQuantity { get; set; }
        public double FuelConsumptionInLitersPerKm { get; set; }
        public double TankCapacity { get; set; }
        public bool IsEmpty { get; set; }

        bool CanDrive(double km);
        bool CanRefuel(double liters);
        void Drive(double km);
        void Refuel(double liters);
    }
}