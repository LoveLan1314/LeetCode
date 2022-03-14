using System.Collections.Generic;

namespace LeetCode.SAOA
{
    internal sealed class PostorderSolution
    {
        public IList<int> Postorder(Node root)
        {
            var result = new List<int>();
            if (root != null)
            {
                Postorder(root, result);
            }
            return result;
        }

        private void Postorder(Node node, IList<int> list)
        {
            foreach (var item in node.children)
            {
                Postorder(item, list);
            }
            list.Add(node.val);
        }

        public class Node
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
    }
}
