namespace NeedForSpeed
{
    public class StartUp
    {
        public static void Main()
        {
            SportCar supra = new SportCar(10, 200);
            supra.Drive(1);
            System.Console.WriteLine(supra.Fuel);
        }
    }
}