using System.Collections.Generic;

namespace LeetCode.SAOA
{
    internal sealed class LevelOrderSolution
    {
        public IList<IList<int>> LevelOrder(Node root)
        {
            var result = new List<IList<int>>();
            Queue<Node> nodes = new Queue<Node>();
            if (root != null)
            {
                nodes.Enqueue(root);
                var count = nodes.Count;
                List<int> list = new List<int>();
                while (nodes.Count > 0)
                {
                    var node = nodes.Dequeue();
                    list.Add(node.val);
                    count--;
                    foreach (var item in node.children)
                    {
                        nodes.Enqueue(item);
                    }
                    if (count == 0)
                    {
                        result.Add(list);
                        list = new List<int>();
                        count = nodes.Count;
                    }
                }
            }
            return result;
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
