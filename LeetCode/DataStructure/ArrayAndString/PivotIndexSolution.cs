using System.Linq;

namespace LeetCode.DataStructure.ArrayAndString
{
    internal class PivotIndexSolution
    {
        public int PivotIndex(int[] nums)
        {
            int sum = nums.Sum();
            int total = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (total == (double)(sum - nums[i]) / 2)
                {
                    return i;
                }
                total += nums[i];
            }
            return -1;
        }
    }
}
