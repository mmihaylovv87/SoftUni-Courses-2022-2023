using CarRacing.Models.Cars.Contracts;
using CarRacing.Repositories.Contracts;
using CarRacing.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CarRacing.Repositories
{
    public class CarRepository : IRepository<ICar>
    {
        private List<ICar> cars = new List<ICar>();

        public CarRepository()
        {
            this.cars = new List<ICar>();
        }

        public IReadOnlyCollection<ICar> Models => this.cars;

        public void Add(ICar model)
        {
            if (model == null)
            {
                throw new ArgumentException(ExceptionMessages.InvalidAddCarRepository);
            }

            this.cars.Add(model);
        }

        public ICar FindBy(string property)
        {
            /*
            if (this.cars.Any(x => x.VIN == property))
            {
                return this.cars.FirstOrDefault(x => x.VIN == property);
            }
            else
            {
                return null;
            }
            */

            return this.cars.FirstOrDefault(x => x.VIN == property);
        }

        public bool Remove(ICar model)
        {
            /*
            if (this.cars.Contains(model))
            {
                this.cars.Remove(model);
                return true;
            }
            else
            {
                return false;
            }
            */

            return this.cars.Remove(model);
        }
    }
}