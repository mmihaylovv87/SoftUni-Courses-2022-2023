using System;
using System.Linq;
using System.Reflection;

namespace AuthorProblem
{
    public class Tracker
    {
        public void PrintMethodsByAuthor()
        {
            Type type = typeof(StartUp);
            MethodInfo[] methods = type.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static);

            foreach (MethodInfo methodInfo in methods)
            {
                if (methodInfo.CustomAttributes.Any(n => n.AttributeType == typeof(AuthorAttribute)))
                {
                    var attrs = methodInfo.GetCustomAttributes(false);
                    foreach (AuthorAttribute attr in attrs)
                        Console.WriteLine($"{methodInfo.Name} is written by {attr.Name}");
                }
            }
        }
    }
}