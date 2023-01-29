using System;

namespace Stealer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Spy spy = new Spy();
            string result = spy.AnalyzeAccessModifiers(typeof(Hacker).FullName);
            Console.WriteLine(result);
        }
    }
}