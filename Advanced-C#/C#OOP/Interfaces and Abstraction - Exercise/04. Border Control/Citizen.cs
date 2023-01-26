namespace _04._Border_Control
{
    public class Citizen : Robot
    {
        public Citizen(string name, int age, string id) : base(name, id)
        {
            this.Age = age;
        }

        public int Age { get; set; }
    }
}
