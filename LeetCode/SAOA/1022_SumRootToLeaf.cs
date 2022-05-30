namespace LeetCode.SAOA
{
    internal sealed class SumRootToLeafSolution
    {
        public int SumRootToLeaf(TreeNode root)
        {
            return DFS(root, 0);
        }

        private int DFS(TreeNode node, int value)
        {
            if (node == null)
            {
                return 0;
            }
            value = (value << 1) | node.val;
            if (node.left == null && node.right == null)
            {
                return value;
            }
            return DFS(node.left, value) + DFS(node.right, value);
        }
    }
}
