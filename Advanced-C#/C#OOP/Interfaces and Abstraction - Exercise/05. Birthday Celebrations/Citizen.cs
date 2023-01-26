namespace _05._Birthday_Celebrations
{
    public class Citizen : Pet
    {
        public Citizen(string name, int age, string id, string birthdate) : base(name, birthdate)
        {
            this.Age = age;
            this.Id = id;
        }

        public int Age { get; }
        public string Id { get; }
    }
}