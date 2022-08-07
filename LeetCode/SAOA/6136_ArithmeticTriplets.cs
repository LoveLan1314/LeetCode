using System.Collections.Generic;

namespace LeetCode.SAOA
{
    internal sealed class ArithmeticTripletsSolution
    {
        public int ArithmeticTriplets(int[] nums, int diff)
        {
            var result = 0;
            var set = new HashSet<int>(nums);
            foreach (var item in nums)
            {
                if (set.Contains(item + diff) && set.Contains(item + diff + diff))
                {
                    result++;
                }
            }
            return result;
        }
    }
}
