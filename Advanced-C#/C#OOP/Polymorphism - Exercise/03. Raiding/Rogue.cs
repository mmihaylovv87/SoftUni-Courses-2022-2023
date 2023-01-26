namespace _03._Raiding
{
    public class Rogue : BaseHero
    {
        public Rogue(string name) : base(name)
        {
        }

        public override int Power => 80;

        public override string CastAbility() => $"Rogue - {this.Name} hit for {this.Power}";
    }
}