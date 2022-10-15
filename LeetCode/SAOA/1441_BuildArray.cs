using System.Collections.Generic;

namespace LeetCode.SAOA
{
    internal sealed class BuildArraySolution
    {
        public IList<string> BuildArray(int[] target, int n)
        {
            var result = new List<string>();
            for (int i = 0, j = 0; i < target.Length && j < n; j++)
            {
                result.Add("Push");
                if (target[i] != j + 1)
                {
                    result.Add("Pop");
                }
                else
                {
                    i++;
                }
            }
            return result;
        }
    }
}
