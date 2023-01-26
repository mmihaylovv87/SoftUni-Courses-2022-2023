using _04._Wild_Farm.Food;

namespace _04._Wild_Farm.Animal
{
    public class Hen : Bird
    {
        public Hen(string name, double weight, double wingSize) : base(name, weight, wingSize)
        {
        }

        public override void Eat(IFood food)
        {
            this.FoodEaten += food.Quantity;
            this.Weight += food.Quantity * 0.35;
        }

        public override string ProduceSound() => "Cluck";
    }
}