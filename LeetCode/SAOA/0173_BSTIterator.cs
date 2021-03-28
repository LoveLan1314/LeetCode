using System.Collections.Generic;

namespace LeetCode.SAOA
{
    internal sealed class BSTIteratorSolution
    {
        private TreeNode _node;
        private readonly Stack<TreeNode> _stack = new Stack<TreeNode>();
        public BSTIteratorSolution(TreeNode root)
        {
            _node = root;
        }

        public int Next()
        {
            while (_node != null)
            {
                _stack.Push(_node);
                _node = _node.left;
            }
            _node = _stack.Pop();
            var result = _node.val;
            _node = _node.right;
            return result;
        }

        public bool HasNext()
        {
            return _node != null || _stack.Count > 0;
        }
    }
}
