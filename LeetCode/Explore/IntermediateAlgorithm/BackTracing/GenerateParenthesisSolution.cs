using System.Collections.Generic;

namespace LeetCode.Explore.IntermediateAlgorithm.BackTracing
{
    internal class GenerateParenthesisSolution
    {
        public IList<string> GenerateParenthesis(int n)
        {
            List<string> result = new List<string>();
            BackTracking(result, string.Empty, n, n);
            return result;
        }

        private void BackTracking(List<string> list, string parenth, int left, int right)
        {
            if (left == 0 && right == 0)
            {
                list.Add(parenth);
                return;
            }
            if (left > 0)
            {
                BackTracking(list, parenth + "(", left - 1, right);
            }
            if (right > 0 && left < right)
            {
                BackTracking(list, parenth + ")", left, right - 1);
            }
        }
    }
}
