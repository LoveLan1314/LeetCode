﻿namespace LeetCode.SAOA
{
    internal sealed class NextGreaterElementSolution1
    {
        public int NextGreaterElement(int n)
        {
            char[] nums = n.ToString().ToCharArray();
            int i = nums.Length - 2;
            while (i >= 0 && nums[i] >= nums[i + 1])
            {
                i--;
            }
            if (i < 0)
            {
                return -1;
            }

            int j = nums.Length - 1;
            while (j >= 0 && nums[i] >= nums[j])
            {
                j--;
            }
            Swap(nums, i, j);
            Reverse(nums, i + 1);
            long ans = long.Parse(new string(nums));
            return ans > int.MaxValue ? -1 : (int)ans;
        }

        private void Reverse(char[] nums, int begin)
        {
            int i = begin, j = nums.Length - 1;
            while (i < j)
            {
                Swap(nums, i, j);
                i++;
                j--;
            }
        }

        private void Swap(char[] nums, int i, int j)
        {
            char temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
    }
}
