namespace LeetCode.SAOA
{
    internal sealed class SubArrayRangesSolution
    {
        public long SubArrayRanges(int[] nums)
        {
            long result = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                int min = nums[i];
                int max = nums[i];
                for (int j = i + 1; j < nums.Length; j++)
                {
                    var value = nums[j];
                    if (value > max)
                    {
                        max = value;
                    }
                    if (value < min)
                    {
                        min = value;
                    }
                    result += max - min;
                }
            }
            return result;
        }
    }
}
