using CarRacing.Models.Racers.Contracts;
using CarRacing.Repositories.Contracts;
using CarRacing.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CarRacing.Repositories
{
    public class RacerRepository : IRepository<IRacer>
    {
        private List<IRacer> racers;

        public RacerRepository()
        {
            this.racers = new List<IRacer>();
        }

        public IReadOnlyCollection<IRacer> Models => this.racers;

        public void Add(IRacer model)
        {
            if (model == null)
            {
                throw new ArgumentException(ExceptionMessages.InvalidAddRacerRepository);
            }

            this.racers.Add(model);
        }

        public IRacer FindBy(string property) => this.racers.FirstOrDefault(x => x.Username == property);
        public bool Remove(IRacer model) => this.Remove(model);
    }
}