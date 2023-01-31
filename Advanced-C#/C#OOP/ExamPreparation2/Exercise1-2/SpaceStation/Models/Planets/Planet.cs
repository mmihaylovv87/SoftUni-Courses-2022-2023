using SpaceStation.Models.Planets.Contracts;
using SpaceStation.Utilities.Messages;
using System;
using System.Collections.Generic;

namespace SpaceStation.Models.Planets
{
    public class Planet : IPlanet
    {
        private string name;

        public Planet(string name)
        {
            this.Items = new List<string>();
            this.Name = name;
        }

        public ICollection<string> Items { get; } 

        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(Name), ExceptionMessages.InvalidPlanetName);
                }

                this.name = value;
            }
        }
    }
}