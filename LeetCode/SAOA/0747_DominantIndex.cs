namespace LeetCode.SAOA
{
    internal sealed class DominantIndexSolution
    {
        public int DominantIndex(int[] nums)
        {
            if (nums.Length == 0)
            {
                return -1;
            }
            if (nums.Length == 1)
            {
                return 0;
            }
            int max = int.MinValue;
            var maxIndex = -1;
            int second = int.MinValue;
            for (int i = 0; i < nums.Length; i++)
            {
                int value = nums[i];
                if (value > second)
                {
                    if (value > max)
                    {
                        second = max;
                        max = value;
                        maxIndex = i;
                    }
                    else
                    {
                        second = value;
                    }
                }
            }
            if (second * 2 <= max)
            {
                return maxIndex;
            }
            else
            {
                return -1;
            }
        }
    }
}
