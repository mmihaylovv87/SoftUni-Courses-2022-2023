using System;
using System.Reflection;
using System.Text;

namespace Stealer
{
    public class Spy
    {
        public string RevealPrivateMethods(string className)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"All Private Methods of Class: {className}");

            Type classType = Type.GetType(className);
            Type baseType = classType.BaseType;
            sb.AppendLine($"Base Class: {baseType.Name}");

            MethodInfo[] privateMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);
            foreach (MethodInfo method in privateMethods)
                sb.AppendLine(method.Name);

            return sb.ToString().Trim();
        }
    }
}