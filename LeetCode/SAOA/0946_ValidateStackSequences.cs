using System.Collections.Generic;

namespace LeetCode.SAOA
{
    internal sealed class ValidateStackSequencesSolution
    {
        public bool ValidateStackSequences(int[] pushed, int[] popped)
        {
            var stack = new Stack<int>();
            for (int i = 0, j = 0; i < pushed.Length; i++)
            {
                stack.Push(pushed[i]);
                while (stack.Count > 0 && stack.Peek() == popped[j])
                {
                    stack.Pop();
                    j++;
                }
            }
            return stack.Count == 0;
        }
    }
}
