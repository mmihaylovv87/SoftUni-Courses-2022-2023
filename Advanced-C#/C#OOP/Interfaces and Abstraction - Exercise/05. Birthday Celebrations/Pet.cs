namespace _05._Birthday_Celebrations
{
    public class Pet : ICreature
    {
        public Pet(string name, string birthdate)
        {
            this.Name = name;
            this.Birthdate = birthdate;
        }

        public string Name { get; }
        public string Birthdate { get; }
    }
}