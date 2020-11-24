using System.Collections.Generic;
using System.Linq;

namespace LeetCode.AlgorithmIntervie.StackAndArray
{
    internal sealed class TopKFrequentSolution
    {
        public int[] TopKFrequent(int[] nums, int k)
        {
            Dictionary<int, int> pairs = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                var num = nums[i];
                if (pairs.ContainsKey(num))
                {
                    pairs[num]++;
                }
                else
                {
                    pairs.Add(num, 1);
                }
            }
            return pairs.OrderByDescending(i => i.Value).Take(k).Select(i => i.Key).ToArray();
        }
    }
}
