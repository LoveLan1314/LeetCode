namespace LeetCode.SAOA
{
    internal sealed class Offer53_SearchSolution
    {
        public int Search(int[] nums, int target)
        {
            int result = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > target)
                {
                    break;
                }
                else if (nums[i] == target)
                {
                    result++;
                }
            }
            return result;
        }

        public int Search1(int[] nums, int target)
        {
            int leftIdx = BinarySearch(nums, target, true);
            int rightIdx = BinarySearch(nums, target, false) - 1;
            if (leftIdx <= rightIdx && rightIdx < nums.Length && nums[leftIdx] == target && nums[rightIdx] == target)
            {
                return rightIdx - leftIdx + 1;
            }
            return 0;
        }

        private int BinarySearch(int[] nums, int target, bool lower)
        {
            int left = 0, right = nums.Length - 1, ans = nums.Length;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (nums[mid] > target || (lower && nums[mid] >= target))
                {
                    right = mid - 1;
                    ans = mid;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return ans;
        }
    }
}
