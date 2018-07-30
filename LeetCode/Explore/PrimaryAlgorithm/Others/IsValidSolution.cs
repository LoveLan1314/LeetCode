using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Explore.PrimaryAlgorithm.Others
{
    class IsValidSolution
    {
        public bool IsValid(string s)
        {
            if (s.Length == 0)
            {
                return true;
            }
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }
                    char top = stack.Pop();
                    if (top == '(' && c == ')')
                    {
                        continue;
                    }
                    if (top == '{' && c == '}')
                    {
                        continue;
                    }
                    if (top == '[' && c == ']')
                    {
                        continue;
                    }
                    return false;
                }
            }
            if (stack.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
