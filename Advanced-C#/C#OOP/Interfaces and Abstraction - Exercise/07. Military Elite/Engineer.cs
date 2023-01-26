using _07._Military_Elite.Interfaces;
using System.Collections.Generic;
using System.Text;

namespace _07._Military_Elite
{
    public class Engineer : SpecialisedSoldier, IEngineer
    {
        public Engineer(int id, string firstName, string lastName, decimal salary, Corps corps) : base(id, firstName, lastName, salary, corps)
        {
            this.Repairs = new List<IRepair>();
        }

        public List<IRepair> Repairs { get; set; }

        public override string ToString()
        {
            string baseInfo = base.ToString();

            StringBuilder sb = new StringBuilder();
            sb.AppendLine(baseInfo);
            sb.AppendLine($"Corps: {Corps}");
            sb.AppendLine("Repairs:");

            foreach (var item in Repairs)
                sb.AppendLine($"  {item}");

            return sb.ToString().TrimEnd();
        }
    }
}