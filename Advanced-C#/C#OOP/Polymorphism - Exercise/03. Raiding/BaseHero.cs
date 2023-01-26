namespace _03._Raiding
{
    public abstract class BaseHero : IBaseHero
    {
        protected BaseHero(string name)
        {
            this.Name = name;
        }
        public string Name { get; }
        public virtual int Power { get; }

        public abstract string CastAbility();
    }
}