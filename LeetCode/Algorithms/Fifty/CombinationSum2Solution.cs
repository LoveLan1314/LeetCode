using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Algorithms.Fifty
{
    internal class CombinationSum2Solution
    {
        private readonly List<IList<int>> _result = new List<IList<int>>();
        public IList<IList<int>> CombinationSum2(int[] candidates, int target)
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
                int temp = 0;
                for (int j = i; j < candidates.Length && candidates[j] <= target; j++)
                {
                    if (candidates[j] != temp)
                    {
                        now.Add(candidates[j]);
                        CombinationSumRecursion(now, j + 1, target, candidates);
                        now.RemoveAt(now.Count - 1);
                        temp = candidates[j];
                    }
                }
            }
        }
    }
}
