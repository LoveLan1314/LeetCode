namespace LeetCode.Explore.IntermediateAlgorithm.SortAndSearch
{
    internal class SortColorsSolution
    {
        public void SortColors(int[] nums)
        {
            int redCount = 0;
            int whiteCount = 0;
            int blueCount = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                switch (nums[i])
                {
                    case 0:
                        redCount++;
                        break;
                    case 1:
                        whiteCount++;
                        break;
                    case 2:
                        blueCount++;
                        break;
                    default:
                        break;
                }
            }
            for (int i = 0; i < nums.Length; i++)
            {
                if (redCount > 0)
                {
                    nums[i] = 0;
                    redCount--;
                }
                else if (whiteCount > 0)
                {
                    nums[i] = 1;
                    whiteCount--;
                }
                else
                {
                    nums[i] = 2;
                }
            }
        }

        public void SortColors1(int[] nums)
        {
            int left = 0;
            int right = nums.Length - 1;
            int temp = 0;
            for (int cur = 0; left <= right && cur <= right; cur++)
            {
                if (nums[cur] == 0)
                {
                    temp = nums[left];
                    nums[left] = nums[cur];
                    nums[cur] = temp;
                    left++;
                }
                else if (nums[cur] == 2)
                {
                    temp = nums[right];
                    nums[right] = nums[cur];
                    nums[cur] = temp;
                    right--;
                    cur--;
                }
            }
        }
    }
}
