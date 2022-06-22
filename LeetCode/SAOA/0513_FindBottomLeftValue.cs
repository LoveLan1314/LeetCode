namespace LeetCode.SAOA
{
    internal sealed class FindBottomLeftValueSolution
    {
        private int curVal;
        private int curHeight;
        public int FindBottomLeftValue(TreeNode root)
        {
            DFS(root, 0);
            return curVal;
        }

        private void DFS(TreeNode root, int height)
        {
            if (root == null)
            {
                return;
            }
            height++;
            DFS(root.left, height);
            DFS(root.right, height);
            if (height > curHeight)
            {
                curHeight = height;
                curVal = root.val;
            }
        }
    }
}
