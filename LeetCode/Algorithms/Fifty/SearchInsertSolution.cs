namespace LeetCode.Algorithms.Fifty
{
    internal class SearchInsertSolution
    {
        public int SearchInsert(int[] nums, int target)
        {
            if (nums == null)
            {
                return 0;
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] >= target)
                {
                    return i;
                }
            }
            return nums.Length;
        }
    }
}
