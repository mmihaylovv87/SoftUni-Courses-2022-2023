namespace SpaceStation.Models.Astronauts
{
    public class Geodesist : Astronauts
    {
        public Geodesist(string name) : base(name, 50)
        {
        }

        public override void Breath()
        {
            base.Breath();
        }
    }
}