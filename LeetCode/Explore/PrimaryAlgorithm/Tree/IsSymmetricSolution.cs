using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Explore.PrimaryAlgorithm.Tree
{
    class IsSymmetricSolution
    {
        public bool IsSymmetric(TreeNode root)
        {
            if(root == null)
            {
                return true;
            }
            return IsSymmetricCore(root.left, root.right);
        }
        private bool IsSymmetricCore(TreeNode left,TreeNode right)
        {
            if(left == null && right == null)
            {
                return true;
            }
            if(left != null && right != null && left.val == right.val)
            {
                return IsSymmetricCore(left.left, right.right) && IsSymmetricCore(left.right, right.left);
            }
            return false;
        }
    }
}
