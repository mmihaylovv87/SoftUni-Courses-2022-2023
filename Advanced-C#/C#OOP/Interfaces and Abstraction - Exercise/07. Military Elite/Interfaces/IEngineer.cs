using System.Collections.Generic;

namespace _07._Military_Elite.Interfaces
{
    public interface IEngineer : ISpecialisedSoldier
    {
        public List<IRepair> Repairs { get; set; }
    }
}