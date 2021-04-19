namespace LeetCode.SAOA
{
    internal sealed class RemoveElementSolution
    {
        public int RemoveElement(int[] nums, int val)
        {
            int n = nums.Length;
            int slow = 0;
            int fast = 0;
            while (fast < n)
            {
                if (nums[fast] != val)
                {
                    nums[slow] = nums[fast];
                    slow++;
                }
                fast++;
            }
            return slow;
        }
    }
}
