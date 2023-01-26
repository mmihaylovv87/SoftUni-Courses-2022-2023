using _04._Wild_Farm.Food;

namespace _04._Wild_Farm.Animal
{
    public class Mouse : Mammal
    {
        public Mouse(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        {
        }

        public override void Eat(IFood food)
        {
            if (!(food is Vegetable || food is Fruit))
                ThrowInvalidOperationExceptionForFood(this, food);

            this.FoodEaten += food.Quantity;
            this.Weight += food.Quantity * 0.10;
        }
        public override string ProduceSound() => "Squeak";
        public override string ToString() => $"{this.GetType().Name} [{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
    }
}