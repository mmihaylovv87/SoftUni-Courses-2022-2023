using System;

namespace Vehicles
{
    public abstract class Vehicle : IVehicle
    {
        private double fuelQuantity;
        private double fuelConsumptionInLitersPerKm;
        private double tankCapacity;

        protected Vehicle(double fuelQuantity, double fuelConsumptionInLitersPerKm, double tankCapacity)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumptionInLitersPerKm = fuelConsumptionInLitersPerKm;
            this.TankCapacity = tankCapacity;
        }

        public double FuelQuantity 
        { 
            get => this.fuelQuantity;
            set => this.fuelQuantity = value;
        }
        public virtual double FuelConsumptionInLitersPerKm
        { 
            get => this.fuelConsumptionInLitersPerKm; 
            set => this.fuelConsumptionInLitersPerKm = value;
        }
        public double TankCapacity
        { 
            get => this.tankCapacity;
            set => this.tankCapacity = value;
        }
        public bool IsEmpty { get; set; }

        public bool CanDrive(double km) => this.FuelQuantity - (km * this.FuelConsumptionInLitersPerKm) >= 0;

        public bool CanRefuel(double liters) => this.TankCapacity - (this.FuelQuantity + liters) >= 0;

        public void Drive(double km)
        {
            if (!CanDrive(km))
                return;
            this.FuelQuantity -= km * this.FuelConsumptionInLitersPerKm;
        }

        public virtual void Refuel(double liters)
        {
            if (liters <= 0)
                throw new ArgumentException("Fuel must be a positive number");

            if (!CanRefuel(liters))
                throw new InvalidOperationException($"Cannot fit {liters} fuel in the tank");

            this.FuelQuantity += liters;
        }
    }
}