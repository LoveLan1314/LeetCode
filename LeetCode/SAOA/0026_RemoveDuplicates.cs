namespace LeetCode.SAOA
{
    internal sealed class RemoveDuplicatesSolution
    {
        public int RemoveDuplicates(int[] nums)
        {
            int n = nums.Length;
            if (n == 0 || n == 1)
            {
                return n;
            }
            int fast = 1;
            int slow = 1;
            while (fast < n)
            {
                if (nums[fast] != nums[fast - 1])
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
