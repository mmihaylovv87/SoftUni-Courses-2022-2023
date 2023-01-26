using _07._Military_Elite.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07._Military_Elite
{
    public class Commando : SpecialisedSoldier, ICommando
    {
        public Commando(int id, string firstName, string lastName, decimal salary, Corps corps) : base(id, firstName, lastName, salary, corps)
        {
            this.Missions = new List<IMission>();
        }

        public List<IMission> Missions { get; set; }

        public void CompleteMission(string codeName)
        {
            var mission = this.Missions.FirstOrDefault(x => x.CodeName == codeName);
            mission.Status = Status.Finished;
        }

        public override string ToString()
        {
            string baseInfo = base.ToString();

            StringBuilder sb = new StringBuilder();
            sb.AppendLine(baseInfo);
            sb.AppendLine($"Corps: {Corps}");
            sb.AppendLine("Missions:");

            foreach (var item in Missions)
                sb.AppendLine($"  {item}");

            return sb.ToString().TrimEnd();
        }
    }
}