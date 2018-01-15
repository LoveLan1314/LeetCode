using System.Collections.Generic;

namespace ConsoleApplication.Algorithms.Fifty
{
    class ValidParentheses
    {
        bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(' || s[i] == '{' || s[i] == '[')
                {
                    stack.Push(s[i]);
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }
                    char c = stack.Pop();
                    switch (c)
                    {
                        case '(':
                            if (s[i] == ')')
                            {
                                continue;
                            }
                            else
                            {
                                return false;
                            }
                        case '{':
                            if (s[i] == '}')
                            {
                                continue;
                            }
                            else
                            {
                                return false;
                            }
                        case '[':
                            if (s[i] == ']')
                            {
                                continue;
                            }
                            else
                            {
                                return false;
                            }
                    }
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