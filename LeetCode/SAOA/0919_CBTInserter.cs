using System.Collections.Generic;

namespace LeetCode.SAOA
{
    internal sealed class CBTInserter
    {
        private readonly Queue<TreeNode> _candidate;
        private readonly TreeNode _root;

        public CBTInserter(TreeNode root)
        {
            _candidate = new Queue<TreeNode>();
            _root = root;

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                TreeNode node = queue.Dequeue();
                if (node.left != null)
                {
                    queue.Enqueue(node.left);
                }
                if (node.right != null)
                {
                    queue.Enqueue(node.right);
                }
                if (!(node.left != null && node.right != null))
                {
                    _candidate.Enqueue(node);
                }
            }
        }

        public int Insert(int val)
        {
            TreeNode child = new TreeNode(val);
            TreeNode node = _candidate.Peek();
            int ret = node.val;
            if (node.left == null)
            {
                node.left = child;
            }
            else
            {
                node.right = child;
                _candidate.Dequeue();
            }
            _candidate.Enqueue(child);
            return ret;
        }

        public TreeNode Get_root()
        {
            return _root;
        }
    }
}
