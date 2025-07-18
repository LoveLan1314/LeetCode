namespace LeetCode._2025
{
    internal sealed class MoveZeroesSolution
    {
        public void MoveZeroes(int[] nums)
        {
            int n = nums.Length;
            int right = 0;
            int left = 0;
            while (right < n)
            {
                if (nums[right] != 0)
                {
                    (nums[right], nums[left]) = (nums[left], nums[right]);
                    left++;
                }
                right++;
            }
        }
    }
}
