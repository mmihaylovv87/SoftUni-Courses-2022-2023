using SpaceStation.Models.Astronauts.Contracts;
using SpaceStation.Models.Planets.Contracts;
using SpaceStation.Repositories.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace SpaceStation.Repositories
{
    public class PlanetRepository : IRepository<IPlanet>
    {
        private readonly List<IPlanet> planets;

        public PlanetRepository()
        {
            this.planets = new List<IPlanet>();
        }

        public IReadOnlyCollection<IPlanet> Models => this.planets;

        public void Add(IPlanet model) => this.planets.Add(model);

        public bool Remove(IPlanet model) => this.planets.Remove(model);

        public IPlanet FindByName(string name) => this.planets.FirstOrDefault(x => x.Name == name);
    }
}