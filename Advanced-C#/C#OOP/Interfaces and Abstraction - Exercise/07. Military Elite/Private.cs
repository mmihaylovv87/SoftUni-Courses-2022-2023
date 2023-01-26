using _07._Military_Elite.Interfaces;

namespace _07._Military_Elite
{
    public class Private : Soldier, IPrivate
    {
        public Private(int id, string firstName, string lastName, decimal salary) : base(id, firstName, lastName)
        {
            this.Salary = salary;
        }

        public decimal Salary { get; set; }

        public override string ToString() => $"Name: {FirstName} {LastName} Id: {Id} Salary: {Salary:f2}";
    }
}