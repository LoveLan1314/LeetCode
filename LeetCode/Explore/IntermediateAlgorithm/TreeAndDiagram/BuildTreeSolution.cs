namespace LeetCode.Explore.IntermediateAlgorithm.TreeAndDiagram
{
    internal class BuildTreeSolution
    {
        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            if (preorder == null || inorder == null || preorder.Length == 0)
            {
                return null;
            }
            return BuildCore(preorder, 0, preorder.Length - 1, inorder, 0, inorder.Length - 1);
        }

        private TreeNode BuildCore(int[] preorder, int preSt, int preEnd, int[] inorder, int inSt, int inEnd)
        {
            int rootValue = preorder[preSt];
            TreeNode root = new TreeNode(rootValue);

            if (preSt == preEnd)
            {
                return root;
            }

            int rootInorder = inSt;
            while (inorder[rootInorder] != rootValue && rootInorder <= inEnd)
            {
                rootInorder++;
            }

            int leftLength = rootInorder - inSt;
            int leftPreEnd = preSt + leftLength;

            if (leftLength > 0)
            {
                root.left = BuildCore(preorder, preSt + 1, leftPreEnd, inorder, inSt, inEnd);
            }
            if (leftLength < preEnd - preSt)
            {
                root.right = BuildCore(preorder, leftPreEnd + 1, preEnd, inorder, rootInorder + 1, inEnd);
            }
            return root;
        }
    }
}
