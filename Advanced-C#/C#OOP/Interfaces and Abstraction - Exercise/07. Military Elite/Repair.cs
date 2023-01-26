using _07._Military_Elite.Interfaces;

namespace _07._Military_Elite
{
    public class Repair : IRepair
    {
        public Repair(string partName, int hoursWorked)
        {
            this.PartName = partName;
            this.HoursWorked = hoursWorked;
        }

        public string PartName { get; set; }
        public int HoursWorked { get; set; }

        public override string ToString() => $"Part Name: {PartName} Hours Worked: {HoursWorked}";
    }
}