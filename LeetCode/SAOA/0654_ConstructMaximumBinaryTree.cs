using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.SAOA
{
    internal sealed class ConstructMaximumBinaryTreeSolution
    {
        public TreeNode ConstructMaximumBinaryTree(int[] nums)
        {
            return Construct(nums, 0, nums.Length - 1);
        }

        private TreeNode Construct(int[] nums, int left, int right)
        {
            if (left > right)
            {
                return null;
            }
            int best = left;
            for (int i = left + 1; i <= right; ++i)
            {
                if (nums[i] > nums[best])
                {
                    best = i;
                }
            }
            var node = new TreeNode(nums[best]);
            node.left = Construct(nums, left, best - 1);
            node.right = Construct(nums, best + 1, right);
            return node;
        }
    }
}
