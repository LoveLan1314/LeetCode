using System.Collections.Generic;

namespace LeetCode.SAOA
{
    internal sealed class FindTargetSolution
    {
        private readonly HashSet<int> _set = new HashSet<int>();

        public bool FindTarget(TreeNode root, int k)
        {
            if (root == null)
            {
                return false;
            }
            if (_set.Contains(k - root.val))
            {
                return true;
            }
            _set.Add(root.val);
            return FindTarget(root.left, k) || FindTarget(root.right, k);
        }
    }
}
