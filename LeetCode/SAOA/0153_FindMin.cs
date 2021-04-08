namespace LeetCode.SAOA
{
    internal sealed class FindMinSolution
    {
        public int FindMin(int[] nums)
        {
            int min = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                //排序数组旋转后得到，则出现的第一个小于第一个值的数就是最小值
                if (nums[i] < min)
                {
                    return nums[i];
                }
            }
            return min;
        }
    }
}
