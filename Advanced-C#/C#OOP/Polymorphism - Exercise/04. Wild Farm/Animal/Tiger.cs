using _04._Wild_Farm.Food;

namespace _04._Wild_Farm.Animal
{
    public class Tiger : Feline
    {
        public Tiger(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
        {
        }

        public override void Eat(IFood food)
        {
            if (!(food is Meat))
                ThrowInvalidOperationExceptionForFood(this, food);

            this.FoodEaten += food.Quantity;
            this.Weight += food.Quantity;
        }

        public override string ProduceSound() => "ROAR!!!";
    }
}