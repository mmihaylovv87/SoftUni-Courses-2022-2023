namespace _06._Food_Shortage
{
    public class Citizen : IBuyer
    {
        public Citizen(string name, int age, string id, string birthdate)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Birthdate = birthdate;
        }

        public string Name { get; }
        public int Age { get; }
        public string Id { get; }
        public string Birthdate { get; }

        public int Food = 10;

        public int BuyFood() => this.Food;
    }
}