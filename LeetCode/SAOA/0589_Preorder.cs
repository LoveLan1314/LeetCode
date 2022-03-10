using System.Collections.Generic;

namespace LeetCode.SAOA
{
    internal sealed class PreorderSolution
    {
        internal sealed class Node
        {
            public int val;
            public IList<Node> children;

            public Node() { }

            public Node(int _val)
            {
                val = _val;
            }

            public Node(int _val, IList<Node> _children)
            {
                val = _val;
                children = _children;
            }
        }

        public IList<int> Preorder(Node root)
        {
            var result = new List<int>();
            if (root != null)
            {
                Stack<Node> stack = new Stack<Node>();
                stack.Push(root);
                while (stack.Count > 0)
                {
                    var node = stack.Pop();
                    result.Add(node.val);
                    for (int i = node.children.Count - 1; i >= 0; i--)
                    {
                        //反着插入，保证顺序读取
                        stack.Push(node.children[i]);
                    }
                }
            }
            return result;
        }
    }
}
