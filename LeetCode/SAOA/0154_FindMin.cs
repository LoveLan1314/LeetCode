namespace LeetCode.SAOA
{
    internal sealed class FindMinSolution2
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

        public int FindMin2(int[] nums)
        {
            int low = 0;
            int high = nums.Length - 1;
            while (low < high)
            {
                int pivot = low + (high - low) / 2;
                if (nums[pivot] < nums[high])
                {
                    high = pivot;
                }
                else if (nums[pivot] > nums[high])
                {
                    low = pivot + 1;
                }
                else
                {
                    high -= 1;
                }
            }
            return nums[low];
        }
    }
}
