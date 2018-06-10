using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Explore.PrimaryAlgorithm.Tree
{
    class IsValidBSTSolution
    {
        public bool IsValidBST(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }
            if (NoGreater(root.left, root.val) && NoLess(root.right, root.val))
            {
                return IsValidBST(root.left) && IsValidBST(root.right);
            }
            else
            {
                return false;
            }
        }
        private bool NoLess(TreeNode node, int val)
        {
            if (node == null)
            {
                return true;
            }
            if (node.val <= val)
            {
                return false;
            }
            return NoLess(node.left, val) && NoLess(node.right, val);
        }
        private bool NoGreater(TreeNode node, int val)
        {
            if (node == null)
            {
                return true;
            }
            if (node.val >= val)
            {
                return false;
            }
            return NoGreater(node.left, val) && NoGreater(node.right, val);
        }
    }
}
