using System;
using System.Collections.Generic;

namespace LeetCode.Algorithms.Fifty
{
    internal class LongestValidParenthesesSolution
    {
        public int LongestValidParentheses(string s)
        {
            int max = 0;
            int start = 0;
            if (s == null)
            {
                return 0;
            }

            int len = s.Length;

            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < len; i++)
            {
                if (s[i] == '(')
                {
                    stack.Push(i);
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        start = i + 1;
                    }
                    else
                    {
                        stack.Pop();
                        if (stack.Count == 0)
                        {
                            max = Math.Max(max, i - start + 1);
                        }
                        else
                        {
                            max = Math.Max(max, i - stack.Peek());
                        }
                    }
                }
            }
            return max;
        }
    }
}
