using _04._Wild_Farm.Food;

namespace _04._Wild_Farm.Animal
{
    public class Cat : Feline
    {
        public Cat(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
        {
        }

        public override void Eat(IFood food)
        {
            if (!(food is Vegetable || food is Meat))
                ThrowInvalidOperationExceptionForFood(this, food);

            this.FoodEaten += food.Quantity;
            this.Weight += food.Quantity * 0.30;
        }

        public override string ProduceSound() => "Meow";
    }
}