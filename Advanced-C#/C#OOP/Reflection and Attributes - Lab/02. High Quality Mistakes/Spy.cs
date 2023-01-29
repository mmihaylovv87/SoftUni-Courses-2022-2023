using System;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Stealer
{
    public class Spy
    {
        public string AnalyzeAccessModifiers(string className)
        {
            Type classType = Type.GetType(className);
            FieldInfo[] wrongFields = classType.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);

            StringBuilder sb = new StringBuilder();
            foreach (FieldInfo field in wrongFields)
                sb.AppendLine($"{field.Name} must be private!");

            MethodInfo[] nonPublicMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);
            foreach (MethodInfo method in nonPublicMethods.Where(m => m.Name.StartsWith("get")))
                sb.AppendLine($"{method.Name} have to be public!");

            MethodInfo[] publicMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.Public);
            foreach (MethodInfo method in publicMethods.Where(m => m.Name.StartsWith("set")))
                sb.AppendLine($"{method.Name} have to be private!");

            return sb.ToString().Trim();
        }
    }
}