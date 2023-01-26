using System.Collections.Generic;

namespace _07._Military_Elite.Interfaces
{
    public interface ICommando : ISpecialisedSoldier
    {
        public List<IMission> Missions { get; set; }

        void CompleteMission(string codeName);
    }
}