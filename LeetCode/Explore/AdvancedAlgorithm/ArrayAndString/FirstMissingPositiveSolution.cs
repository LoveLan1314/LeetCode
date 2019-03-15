namespace LeetCode.Explore.AdvancedAlgorithm.ArrayAndString
{
    internal class FirstMissingPositiveSolution
    {
        public int FirstMissingPositive(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] <= 0)
                {
                    continue;
                }
                while (nums[i] > 0 && nums[i] <= nums.Length && nums[nums[i] - 1] != nums[i])
                {
                    Swap(nums, i, nums[i] - 1);
                }
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != i + 1)
                {
                    return i + 1;
                }
            }
            return nums.Length + 1;
        }

        private void Swap(int[] nums, int i, int j)
        {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
    }
}
