namespace AuthorProblem
{
    public class StartUp
    {
        [Author("George")]
        public static void Main()
        {
            Tracker tracker = new Tracker();
            tracker.PrintMethodsByAuthor("George");
        }
    }
}