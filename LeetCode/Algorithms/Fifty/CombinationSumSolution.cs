using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Algorithms.Fifty
{
    internal class CombinationSumSolution
    {
        private readonly List<IList<int>> _result = new List<IList<int>>();
        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            if (candidates.Length == 0)
            {
                return _result;
            }
            Array.Sort(candidates);
            CombinationSumRecursion(new List<int>(), 0, target, candidates);
            return _result;
        }

        private void CombinationSumRecursion(IList<int> now, int i, int target, int[] candidates)
        {
            var sum = now.Sum();
            if (sum == target)
            {
                _result.Add(new List<int>(now));
                return;
            }
            else if (sum > target)
            {
                return;
            }
            else
            {
                for (int j = i; j < candidates.Length && candidates[j] <= target; j++)
                {
                    now.Add(candidates[j]);
                    CombinationSumRecursion(now, j, target, candidates);
                    now.RemoveAt(now.Count - 1);
                }
            }
        }
    }
}
