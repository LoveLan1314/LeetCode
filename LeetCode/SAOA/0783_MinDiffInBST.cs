using System;

namespace LeetCode.SAOA
{
    internal sealed class MinDiffInBSTSolution
    {
        private int _pre;
        private int _ans;
        public int MinDiffInBST(TreeNode root)
        {
            _ans = int.MaxValue;
            _pre = -1;
            Dfs(root);
            return _ans;
        }

        private void Dfs(TreeNode root)
        {
            if (root == null)
            {
                return;
            }
            Dfs(root.left);
            if (_pre == -1)
            {
                _pre = root.val;
            }
            else
            {
                _ans = Math.Min(_ans, root.val - _pre);
                _pre = root.val;
            }
            Dfs(root.right);
        }
    }
}
