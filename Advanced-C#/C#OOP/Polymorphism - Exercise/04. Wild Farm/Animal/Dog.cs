using _04._Wild_Farm.Food;

namespace _04._Wild_Farm.Animal
{
    public class Dog : Mammal
    {
        public Dog(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
        {
        }

        public override void Eat(IFood food)
        {
            if (!(food is Meat))
                ThrowInvalidOperationExceptionForFood(this, food);

            this.FoodEaten += food.Quantity;
            this.Weight += food.Quantity * 0.40;
        }
        public override string ProduceSound() => "Woof!";
        public override string ToString() => $"{this.GetType().Name} [{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
    }
}