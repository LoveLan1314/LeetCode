using System.Collections.Generic;
using System.Linq;

namespace LeetCode.AlgorithmIntervie.BeforeStart
{
    internal sealed class MajorityElementSolution
    {
        public int MajorityElement(int[] nums)
        {
            var pairs = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (pairs.TryGetValue(nums[i], out int value))
                {
                    pairs[nums[i]] = value + 1;
                }
                else
                {
                    pairs.Add(nums[i], 1);
                }
            }
            return pairs.OrderByDescending(i => i.Value).First().Key;
        }

        public int MajorityElement1(int[] nums)
        {
            int result = nums[0];
            int cnt = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == result)
                {
                    cnt++;
                }
                else
                {
                    cnt--;
                    if (cnt == 0)
                    {
                        result = nums[i];
                        cnt = 1;
                    }
                }
            }
            return result;
        }
    }
}
