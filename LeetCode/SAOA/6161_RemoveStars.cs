using System.Collections.Generic;
using System.Text;

namespace LeetCode.SAOA
{
    internal sealed class RemoveStarsSolution
    {
        public string RemoveStars(string s)
        {
            var stack = new Stack<char>();
            foreach (var item in s)
            {
                if (item == '*')
                {
                    if (stack.Count > 0)
                    {
                        stack.Pop();
                    }
                }
                else
                {
                    stack.Push(item);
                }
            }
            var sb = new StringBuilder();
            while (stack.Count > 0)
            {
                sb.Insert(0, stack.Pop());
            }
            return sb.ToString();
        }
    }
}
