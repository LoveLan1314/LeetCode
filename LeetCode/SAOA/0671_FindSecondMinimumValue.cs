using System;

namespace LeetCode.SAOA
{
    internal sealed class FindSecondMinimumValueSolution
    {
        public int FindSecondMinimumValue(TreeNode root)
        {
            return FirstBigger(root, root.val);
        }

        private int FirstBigger(TreeNode node, int val)
        {
            if (node == null)
            {
                return -1;
            }
            if (node.val > val)
            {
                return node.val;
            }
            int left = FirstBigger(node.left, val);
            int right = FirstBigger(node.right, val);
            if (left < 0)
            {
                return right;
            }
            if (right < 0)
            {
                return left;
            }
            return Math.Min(left, right);
        }
    }
}
