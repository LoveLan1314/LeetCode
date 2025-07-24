using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode._2025
{
    internal sealed class RotateSolution
    {
        public void Rotate(int[] nums, int k)
        {
            k %= nums.Length;
            Reverse(nums, 0, nums.Length - 1);
            Reverse(nums, 0, k - 1);
            Reverse(nums, k, nums.Length - 1);
        }

        private void Reverse(int[] nums, int start, int end)
        {
            while (start < end)
            {
                (nums[end], nums[start]) = (nums[start], nums[end]);
                start += 1;
                end -= 1;
            }
        }
    }
}
