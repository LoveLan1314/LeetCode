using System.Collections.Generic;
using System.Text;

namespace LeetCode.Explore.AdvancedAlgorithm.ArrayAndString
{
    internal class CalculateSolution
    {
        public int Calculate(string s)
        {
            Stack<string> stack = new Stack<string>();
            for (int i = 0; i < s.Length; i++)
            {
                string GetValue()
                {
                    char c = s[i];
                    while (c == ' ')
                    {
                        c = s[++i];
                    }
                    StringBuilder sb = new StringBuilder(ConvertCharToInt(c).ToString());
                    if (i + 1 < s.Length)
                    {
                        c = s[i + 1];
                        while (c >= 48 && c <= 57)
                        {
                            sb.Append(ConvertCharToInt(c));
                            i++;
                            if (i + 1 == s.Length)
                            {
                                break;
                            }
                            c = s[i + 1];
                        }
                    }
                    return sb.ToString();
                }
                if (s[i] == ' ')
                {
                    continue;
                }
                if (s[i] == '*')
                {
                    i++;
                    stack.Push((int.Parse(stack.Pop()) * int.Parse(GetValue())).ToString());
                    continue;
                }
                if (s[i] == '/')
                {
                    i++;
                    stack.Push((int.Parse(stack.Pop()) / int.Parse(GetValue())).ToString());
                    continue;
                }
                if (s[i] == '+' || s[i] == '-')
                {
                    stack.Push(s[i].ToString());
                    continue;
                }
                stack.Push(GetValue());
            }
            List<string> vs = new List<string>(stack.ToArray());
            int result = int.Parse(vs[vs.Count - 1]);
            for (int i = vs.Count - 2; i >= 0; i--)
            {
                if (vs[i] == "+")
                {
                    result += int.Parse(vs[--i]);
                }
                if (vs[i] == "-")
                {
                    result -= int.Parse(vs[--i]);
                }
            }
            return result;
        }

        private int ConvertCharToInt(char c)
        {
            return int.Parse(c.ToString());
        }
    }
}
