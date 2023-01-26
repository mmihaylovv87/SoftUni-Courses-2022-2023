namespace Animals
{
    public class Animal
    {
        private string name;
        private string favouriteFood;

        protected Animal(string name, string favouriteFood)
        {
            this.name = name;
            this.favouriteFood = favouriteFood;
        }

        public virtual string ExplainSelf() => $"I am {this.name} and my favourite food is {this.favouriteFood}";
    }
}