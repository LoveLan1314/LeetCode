namespace LeetCode._2025
{
    internal sealed class SubarraySumSolution
    {
        public int SubarraySum(int[] nums, int k)
        {
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int sum = 0;
                for (int j = i; j >= 0; j--)
                {
                    sum += nums[j];
                    if (sum == k)
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}