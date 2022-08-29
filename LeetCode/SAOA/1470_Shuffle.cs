namespace LeetCode.SAOA
{
    internal sealed class ShuffleSolution
    {
        public int[] Shuffle(int[] nums, int n)
        {
            var result = new int[2 * n];
            for (int i = 0; i < n; i++)
            {
                result[2 * i] = nums[i];
                result[2 * i + 1] = nums[n + i];
            }
            return result;
        }
    }
}
