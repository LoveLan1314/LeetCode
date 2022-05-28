using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.SAOA
{
    internal sealed class RemoveOuterParenthesesSolution
    {
        public string RemoveOuterParentheses(string s)
        {
            var res = new StringBuilder();
            Stack<char> stack = new Stack<char>();
            foreach (char c in s)
            {
                if (c == ')')
                {
                    stack.Pop();
                }
                if (stack.Count > 0)
                {
                    res.Append(c);
                }
                if (c == '(')
                {
                    stack.Push(c);
                }
            }
            return res.ToString();
        }
    }
}
