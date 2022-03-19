using System.Text;

namespace LeetCode.SAOA
{
    internal sealed class Tree2strSolution
    {
        public string Tree2str(TreeNode root)
        {
            if (root == null)
            {
                return "";
            }
            var sb = new StringBuilder();
            DFS(root, sb);
            return sb.ToString();
        }

        private void DFS(TreeNode node, StringBuilder sb)
        {
            if (node != null)
            {
                sb.Append(node.val);
                if (node.left != null || node.right != null)
                {
                    sb.Append('(');
                    DFS(node.left, sb);
                    sb.Append(')');
                }
                if (node.right != null)
                {
                    sb.Append('(');
                    DFS(node.right, sb);
                    sb.Append(')');
                }
            }
        }
    }
}
