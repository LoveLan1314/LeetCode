using System.Linq;

namespace LeetCode.SAOA
{
    internal sealed class MinMovesSolution
    {
        public int MinMoves(int[] nums)
        {
            int min = nums.Min();
            int result = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                result += nums[i] - min;
            }
            return result;
        }
    }
}
