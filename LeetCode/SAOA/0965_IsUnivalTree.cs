using System.Collections.Generic;

namespace LeetCode.SAOA
{
    internal sealed class IsUnivalTreeSolution
    {
        public bool IsUnivalTree(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }
            var value = root.val;
            var query = new Queue<TreeNode>();
            query.Enqueue(root.left);
            query.Enqueue(root.right);
            while (query.Count > 0)
            {
                var node = query.Dequeue();
                if (node != null)
                {
                    if (value != node.val)
                    {
                        return false;
                    }
                    else
                    {
                        query.Enqueue(node.left);
                        query.Enqueue(node.right);
                    }
                }
            }
            return true;
        }
    }
}
