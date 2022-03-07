using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.SAOA
{
    internal sealed class ConvertToBase7Solution
    {
        public string ConvertToBase7(int num)
        {
            StringBuilder sb = new StringBuilder();
            if (num < 0)
            {
                sb.Append('-');
                num = Math.Abs(num);
            }
            Stack<int> stack = new Stack<int>();
            while (num >= 7)
            {
                stack.Push(num % 7);
                num /= 7;
            }
            stack.Push(num);
            while (stack.Count > 0)
            {
                sb.Append(stack.Pop());
            }
            return sb.ToString();
        }
    }
}
