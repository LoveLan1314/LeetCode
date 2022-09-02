using System;

namespace LeetCode.SAOA
{
    internal sealed class LongestUnivaluePathSolution
    {
        private int _result;

        public int LongestUnivaluePath(TreeNode root)
        {
            _result = 0;
            DFS(root);
            return _result;
        }

        private int DFS(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            int left = DFS(root.left), right = DFS(root.right);
            int left1 = 0, right1 = 0;
            if (root.left != null && root.left.val == root.val)
            {
                left1 = left + 1;
            }
            if (root.right != null && root.right.val == root.val)
            {
                right1 = right + 1;
            }
            _result = Math.Max(_result, left1 + right1);
            return Math.Max(left1, right1);
        }
    }
}
