using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class valid_parentheses
    {
        public static bool IsValidA(string s)
        {
            while (s.Contains("()") || s.Contains("[]") || s.Contains("{}"))
            {
                s = s.Replace("()", "").Replace("[]", "").Replace("{}", "");
            }

            return s.Length == 0;
        }
        public static bool IsValidB(string s)
        {
            Dictionary<char, char> bracketsMap = new Dictionary<char, char>{
            {'{',  '}'},
            {'(',  ')'},
            {'[',  ']'},
        };
            Stack<char> openBrackets = new Stack<char>();

            foreach (char bracket in s)
            {
                if (bracketsMap.ContainsKey(bracket))
                {
                    openBrackets.Push(bracket);
                }
                else
                {
                    if (openBrackets.Count == 0)
                    {
                        return false;
                    }
                    if (bracketsMap[openBrackets.Pop()] == bracket)
                    {
                        continue;
                    };
                    return false;
                }
            }
            return openBrackets.Count == 0;
        }


        public static void Run()
        {
            string s0 = "()[]{}";
            string s1 = "()";
            string s2 = "(]";
            string s3 = "{[]}";

            Console.WriteLine(IsValidA(s0));
        }




    }
}
