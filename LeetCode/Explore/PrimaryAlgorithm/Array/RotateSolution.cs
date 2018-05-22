using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Explore.PrimaryAlgorithm
{
    class RotateSolution
    {
        /// <summary>
        /// 该方法超时
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        public void Rotate(int[] nums, int k)
        {
            int length = nums.Length;
            while (k > 0)
            {
                int t = nums[length - 1];
                for (int i = length - 1; i > 0; i--)
                {
                    nums[i] = nums[i - 1];
                }
                nums[0] = t;
                k--;
            }
        }

        public void Rotate2(int[] nums, int k)
        {
            if (nums == null || nums.Length == 0 || k % nums.Length == 0)
            {
                return;
            }

            int turns = k % nums.Length;
            int middle = nums.Length - turns;

            Reverse(nums, 0, middle - 1);
            Reverse(nums, middle, nums.Length - 1);
            Reverse(nums, 0, nums.Length - 1);
        }

        private void Reverse(int[] arr, int s, int e)
        {
            while (s < e)
            {
                int temp = arr[s];
                arr[s] = arr[e];
                arr[e] = temp;

                s++;
                e--;
            }
        }
    }
}
