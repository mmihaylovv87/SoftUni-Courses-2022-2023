using _07._Military_Elite.Interfaces;

namespace _07._Military_Elite
{
    public class Mission : IMission
    {
        public Mission(string codeName, Status status)
        {
            this.CodeName = codeName;
            this.Status = status;
        }

        public string CodeName { get; set; }
        public Status Status { get; set; }

        public override string ToString() => $"Code Name: {CodeName} State: {Status}";
    }
}