using System;

namespace LeetCode.SAOA
{
    internal sealed class AnswerQueriesSolution
    {
        public int[] AnswerQueries(int[] nums, int[] queries)
        {
            Array.Sort(nums);
            var result = new int[queries.Length];
            for (int i = 0; i < queries.Length; i++)
            {
                var value = queries[i];
                var sum = 0;
                var j = 0;
                for (; j < nums.Length; j++)
                {
                    sum += nums[j];
                    if (sum > value)
                    {
                        break;
                    }
                }
                result[i] = j;
            }
            return result;
        }
    }
}
