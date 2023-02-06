namespace LeetCode.SAOA
{
    internal sealed class _2331_EvaluateTreeSolution
    {
        public bool EvaluateTree(TreeNode root)
        {
            if (root.left == null && root.right == null)
            {
                return root.val == 1;
            }
            if (root.val == 2)
            {
                return EvaluateTree(root.left) || EvaluateTree(root.right);
            }
            else
            {
                return EvaluateTree(root.left) && EvaluateTree(root.right);
            }
        }
    }
}
