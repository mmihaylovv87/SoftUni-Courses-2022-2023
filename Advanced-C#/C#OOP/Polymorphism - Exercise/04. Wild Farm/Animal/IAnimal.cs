using _04._Wild_Farm.Food;

namespace _04._Wild_Farm.Animal
{
    public interface IAnimal
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public int FoodEaten { get; set; }

        string ProduceSound();
        void Eat(IFood food);
    }
}