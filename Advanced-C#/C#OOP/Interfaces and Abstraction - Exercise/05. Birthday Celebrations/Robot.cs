namespace _05._Birthday_Celebrations
{
    public class Robot : IRobot
    {
        public Robot(string name, string id)
        {
            this.Name = name;
            this.Id = id;
        }

        public string Name { get; }
        public string Id { get; }
    }
}