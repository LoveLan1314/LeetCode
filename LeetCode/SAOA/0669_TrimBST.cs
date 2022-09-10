﻿namespace LeetCode.SAOA
{
    internal sealed class TrimBSTSolution
    {
        public TreeNode TrimBST(TreeNode root, int low, int high)
        {
            if (root == null)
            {
                return null;
            }
            if (root.val < low)
            {
                return TrimBST(root.right, low, high);
            }
            else if (root.val > high)
            {
                return TrimBST(root.left, low, high);
            }
            else
            {
                root.left = TrimBST(root.left, low, high);
                root.right = TrimBST(root.right, low, high);
                return root;
            }
        }
    }
}
