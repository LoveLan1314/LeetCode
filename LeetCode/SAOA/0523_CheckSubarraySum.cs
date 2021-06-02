using System.Collections.Generic;

namespace LeetCode.SAOA
{
    internal sealed class CheckSubarraySumSolution
    {
        public bool CheckSubarraySum(int[] nums, int k)
        {
            int n = nums.Length;
            if (n < 2)
            {
                return false;
            }
            for (int i = 0; i < n - 1; i++)
            {
                int sum = nums[i];
                for (int j = i + 1; j < n; j++)
                {
                    sum += nums[j];
                    if (sum % k == 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool CheckSubarraySum1(int[] nums, int k)
        {
            int n = nums.Length;
            if (n < 2)
            {
                return false;
            }
            var dictionary = new Dictionary<int, int>
            {
                { 0, -1 }  //这个地方很灵性
            };
            int remainder = 0;
            //利用到了同余定理
            for (int i = 0; i < n; i++)
            {
                remainder = (remainder + nums[i]) % k;
                if (dictionary.ContainsKey(remainder))
                {
                    int prevIndex = dictionary[remainder];
                    if (i - prevIndex >= 2)
                    {
                        return true;
                    }
                }
                else
                {
                    dictionary.Add(remainder, i);
                }
            }
            return false;
        }
    }
}
