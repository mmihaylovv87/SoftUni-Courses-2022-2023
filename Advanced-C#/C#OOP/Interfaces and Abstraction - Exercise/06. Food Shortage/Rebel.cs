namespace _06._Food_Shortage
{
    public class Rebel : IBuyer
    {
        public Rebel(string name, int age, string group)
        {
            this.Name = name;
            this.Age = age;
            this.Group = group;
        }

        public string Name { get; }
        public int Age { get; }
        public string Group { get; }

        public int Food = 5;

        public int BuyFood() => this.Food;
    }
}