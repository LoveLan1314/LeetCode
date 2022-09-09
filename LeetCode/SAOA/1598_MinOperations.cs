using System.Collections.Generic;

namespace LeetCode.SAOA
{
    internal sealed class MinOperationsSolution
    {
        public int MinOperations(string[] logs)
        {
            var stack = new Stack<string>();
            foreach (var item in logs)
            {
                if (item == "../")
                {
                    if (stack.Count > 0)
                    {
                        stack.Pop();
                    }
                }
                else if (item == "./")
                {

                }
                else
                {
                    stack.Push(item);
                }
            }
            return stack.Count;
        }

        public int MinOperations1(string[] logs)
        {
            var depth = 0;
            foreach (var item in logs)
            {
                if (item == "../")
                {
                    if (depth > 0)
                    {
                        depth--;
                    }
                }
                else if (item == "./")
                {

                }
                else
                {
                    depth++;
                }
            }
            return depth;
        }
    }
}
