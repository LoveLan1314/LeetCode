namespace LeetCode.SAOA
{
    internal sealed class SearchBSTSolution
    {
        public TreeNode SearchBST(TreeNode root, int val)
        {
            while (root != null)
            {
                if (root.val == val)
                {
                    return root;
                }
                else if (root.val > val)
                {
                    root = root.left;
                }
                else
                {
                    root = root.right;
                }
            }
            return null;
        }
    }
}
