using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Explore.IntermediateAlgorithm.SortAndSearch
{
    class TopKFrequentSolution
    {
        public IList<int> TopKFrequent(int[] nums,int k)
        {
            Dictionary<int, int> pairs = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!pairs.ContainsKey(nums[i]))
                {
                    pairs.Add(nums[i], 1);
                }
                else
                {
                    pairs[nums[i]] = pairs[nums[i]] + 1;
                }
            }
            return pairs.OrderByDescending(i => i.Value).Take(k).Select(i => i.Key).ToList();
        }
    }
}
