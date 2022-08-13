using System.Collections.Generic;

namespace LeetCode.SAOA
{
    internal sealed class MaxChunksToSortedSolution
    {
        public int MaxChunksToSorted(int[] arr)
        {
            var stack = new Stack<int>();
            foreach (var num in arr)
            {
                if (stack.Count == 0 || num >= stack.Peek())
                {
                    stack.Push(num);
                }
                else
                {
                    int mx = stack.Pop();
                    while (stack.Count > 0 && stack.Peek() > num)
                    {
                        stack.Pop();
                    }
                    stack.Push(mx);
                }
            }
            return stack.Count;
        }
    }
}
