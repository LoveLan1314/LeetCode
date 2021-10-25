using System.Collections.Generic;

namespace LeetCode.SAOA
{
    internal sealed class NumSubarraysWithSumSolution
    {
        //超时
        public int NumSubarraysWithSum(int[] nums, int goal)
        {
            int result = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int sum = 0;
                for (int j = i; j < nums.Length; j++)
                {
                    sum += nums[j];
                    if (sum == goal)
                    {
                        result++;
                    }
                    else if (sum > goal)
                    {
                        break;
                    }
                }
            }
            return result;
        }

        public int NumSubarraysWithSum2(int[] nums, int goal)
        {
            int result = 0;
            int sum = 0;
            var pairs = new Dictionary<int, int>();
            foreach (var num in nums)
            {
                if (pairs.ContainsKey(sum))
                {
                    pairs[sum]++;
                }
                else
                {
                    pairs.Add(sum, 1);
                }
                sum += num;
                if (pairs.TryGetValue(sum - goal, out var val))
                {
                    result += val;
                }
            }
            return result;
        }
    }
}
