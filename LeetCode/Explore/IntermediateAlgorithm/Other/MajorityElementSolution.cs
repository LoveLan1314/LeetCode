using System.Collections.Generic;

namespace LeetCode.Explore.IntermediateAlgorithm.Other
{
    internal class MajorityElementSolution
    {
        public int MajorityElement(int[] nums)
        {
            Dictionary<int, int> pairs = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (pairs.ContainsKey(nums[i]))
                {
                    pairs[nums[i]]++;
                }
                else
                {
                    pairs.Add(nums[i], 1);
                }
            }
            int count = nums.Length / 2;
            foreach (var item in pairs)
            {
                if (item.Value > count)
                {
                    return item.Key;
                }
            }
            return 0;
        }
    }
}
