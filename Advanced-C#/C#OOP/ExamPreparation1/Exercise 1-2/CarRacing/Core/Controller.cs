using CarRacing.Core.Contracts;
using CarRacing.Models.Cars;
using CarRacing.Models.Cars.Contracts;
using CarRacing.Models.Maps;
using CarRacing.Models.Maps.Contracts;
using CarRacing.Models.Racers;
using CarRacing.Models.Racers.Contracts;
using CarRacing.Repositories;
using CarRacing.Utilities.Messages;
using System;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.Serialization;
using System.Text;

namespace CarRacing.Core
{
    public class Controller : IController
    {
        private CarRepository cars;
        private RacerRepository racers;
        private IMap map;

        public Controller()
        {
            this.cars = new CarRepository();
            this.racers = new RacerRepository();
            this.map = new Map();
        }

        public string AddCar(string type, string make, string model, string VIN, int horsePower)
        {
            ICar car;
            if (type == "SuperCar")
            {
                car = new SuperCar(make, model, VIN, horsePower);
            }
            else if (type == "TunedCar")
            {
                car = new TunedCar(make, model, VIN, horsePower);
            }
            else 
            {
                throw new ArgumentException(ExceptionMessages.InvalidCarType);
            }

            this.cars.Add(car);

            // return string.Format(OutputMessages.SuccessfullyAddedCar, car.Make, car.Model, car.VIN);
            return $"Successfully added car {car.Make} {car.Model} ({car.VIN}).";
        }

        public string AddRacer(string type, string username, string carVIN)
        {
            ICar car = this.cars.FindBy(carVIN);
            if (car == null)
            {
                throw new ArgumentException(ExceptionMessages.CarCannotBeFound);
            }

            IRacer racer;
            if (type == "ProfessionalRacer")
            {
                racer = new ProfessionalRacer(username, car);
            }
            else if (type == "StreetRacer")
            {
                racer = new StreetRacer(username, car);
            }
            else
            {
                throw new ArgumentException(ExceptionMessages.InvalidRacerType);
            }

            this.racers.Add(racer);
            return $"Successfully added racer {racer.Username}";
        }

        public string BeginRace(string racerOneUsername, string racerTwoUsername)
        {
            IRacer racer1 = this.racers.FindBy(racerOneUsername);
            if (racer1 == null)
            {
                throw new ArgumentException($"Racer {racerOneUsername} cannot be found!");
            }

            IRacer racer2 = this.racers.FindBy(racerTwoUsername);
            if (racer2 == null)
            {
                throw new ArgumentException($"Racer {racerTwoUsername} cannot be found!");
            }

            return this.map.StartRace(racer1, racer2);
        }

        public string Report()
        {
            var racers = this.racers.Models
                .OrderByDescending(x => x.DrivingExperience)
                .ThenBy(x => x.Username);

            StringBuilder sb = new StringBuilder();
            foreach (var racer in racers)
                sb.AppendLine(racer.ToString());

            return sb.ToString().TrimEnd();
        }
    }
}