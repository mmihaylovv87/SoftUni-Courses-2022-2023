namespace _03._Raiding
{
    public class Warrior : BaseHero
    {
        public Warrior(string name) : base(name)
        {
        }

        public override int Power => 100;

        public override string CastAbility() => $"Warrior - {this.Name} hit for {this.Power}";
    }
}