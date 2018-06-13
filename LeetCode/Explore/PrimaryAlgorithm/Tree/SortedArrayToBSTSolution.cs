using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Explore.PrimaryAlgorithm.Tree
{
    class SortedArrayToBSTSolution
    {
        public TreeNode SortedArrayToBST(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return null;
            }
            return GetTree(nums, 0, nums.Length - 1);
        }
        private TreeNode GetTree(int[] nums, int l, int r)
        {
            if (l <= r)
            {
                //通过+1来获取上整数
                int mid = (l + r + 1) / 2;
                TreeNode node = new TreeNode(nums[mid])
                {
                    left = GetTree(nums, l, mid - 1),
                    right = GetTree(nums, mid + 1, r)
                };
                return node;
            }
            else
            {
                return null;
            }
        }
    }
}
