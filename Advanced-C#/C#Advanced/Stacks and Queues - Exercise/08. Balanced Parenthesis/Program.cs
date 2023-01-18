using System;
using System.Collections.Generic;

namespace _08._Balanced_Parenthesis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<char> stack = new Stack<char>();
            string input = Console.ReadLine();
            foreach (char ch in input)
                stack.Push(ch);
            
            int a = 0;
            int b = 0;
            int c = 0;
            int d = 0;
            int e = 0;
            int f = 0;

            while (stack.Count > 0)
            {
                if (stack.Peek() == '{') a++;
                else if (stack.Peek() == '}') b++;
                else if (stack.Peek() == '[') c++;
                else if (stack.Peek() == ']') d++;
                else if (stack.Peek() == '(') e++;
                else if (stack.Peek() == ')') f++;
                stack.Pop();
            }
            if (a == b && c == d && e == f) Console.WriteLine("YES");
            else Console.WriteLine("NO");
        }
    }
}