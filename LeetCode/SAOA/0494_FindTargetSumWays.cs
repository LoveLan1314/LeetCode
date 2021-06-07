using System.Linq;

namespace LeetCode.SAOA
{
    internal sealed class FindTargetSumWaysSolution
    {
        private int _count = 0;
        public int FindTargetSumWays(int[] nums, int target)
        {
            Backtrack(nums, target, 0, 0);
            return _count;
        }

        private void Backtrack(int[] nums, int target, int index, int sum)
        {
            if (nums.Length == index)
            {
                if (sum == target)
                {
                    _count++;
                }
            }
            else
            {
                Backtrack(nums, target, index + 1, sum + nums[index]);
                Backtrack(nums, target, index + 1, sum - nums[index]);
            }
        }

        public int FindTargetSumWays1(int[] nums, int target)
        {
            int sum = nums.Sum();
            int diff = sum - target;
            if (diff < 0 || diff % 2 != 0)
            {
                return 0;
            }
            int n = nums.Length;
            int neg = diff / 2;
            int[,] dp = new int[n + 1, neg + 1];
            dp[0, 0] = 1;
            for (int i = 1; i <= n; i++)
            {
                int num = nums[i - 1];
                for (int j = 0; j <= neg; j++)
                {
                    dp[i, j] = dp[i - 1, j];
                    if (j >= num)
                    {
                        dp[i, j] += dp[i - 1, j - num];
                    }
                }
            }
            return dp[n, neg];
        }
    }
}
