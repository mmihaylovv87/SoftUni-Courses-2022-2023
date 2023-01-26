namespace _06._Food_Shortage
{
    public interface IBuyer
    {
        public string Name { get; }
        public int Age { get; }
        public virtual int Food => 0;

        public int BuyFood();
    }
}