namespace _07._Military_Elite.Interfaces
{
    public interface ISpecialisedSoldier : IPrivate
    {
        public Corps Corps { get; set; }
    }
}