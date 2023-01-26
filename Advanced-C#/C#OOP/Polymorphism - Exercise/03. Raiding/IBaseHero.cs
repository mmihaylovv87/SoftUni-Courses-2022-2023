namespace _03._Raiding
{
    public interface IBaseHero
    {
        public string Name { get; }
        public int Power { get; }

        public string CastAbility();
    }
}