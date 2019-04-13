using System;

namespace LeetCode.Algorithms.Fifty
{
    internal class NextPermutationSolution
    {
        public void NextPermutation(int[] nums)
        {
            if (nums.Length == 0 || nums.Length == 1)
            {
                return;
            }
            if (nums.Length == 2)
            {
                Swap(nums, 0, 1);
                return;
            }
            for (int i = nums.Length - 1; i > 0; i--)
            {
                if (nums[i] > nums[i - 1])
                {
                    for (int j = nums.Length - 1; j >= i; j--)
                    {
                        if (nums[j] > nums[i - 1])
                        {
                            Swap(nums, i - 1, j);
                            break;
                        }
                    }
                    for (int j = 0; j < (nums.Length - i) / 2; j++)
                    {
                        Swap(nums, i + j, nums.Length - j - 1);
                    }
                    return;
                }
            }
            for (int i = 0; i < nums.Length / 2; i++)
            {
                Swap(nums, i, nums.Length - i - 1);
            }
        }

        public void NextPermutation1(int[] nums)
        {
            int n = nums.Length;
            int i = n - 2;
            int j = n - 1;
            while (i >= 0 && nums[i] >= nums[i + 1])
            {
                i--;
            }
            if (i >= 0)
            {
                while (nums[j] <= nums[i])
                {
                    j--;
                }
                Swap(nums, i, j);
            }
            Array.Reverse(nums, i + 1, n - i - 1);
        }

        private void Swap(int[] nums, int left, int right)
        {
            int temp = nums[left];
            nums[left] = nums[right];
            nums[right] = temp;
        }
    }
}
