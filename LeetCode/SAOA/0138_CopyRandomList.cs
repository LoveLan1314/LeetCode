using System.Collections.Generic;

namespace LeetCode.SAOA
{
    internal sealed class CopyRandomListSolution
    {
        public Node CopyRandomList(Node head)
        {
            var root = new Node(0)
            {
                next = head
            };
            var rootCopy = new Node(0);
            var nodeCopy = rootCopy;
            Dictionary<Node, Node> pairs = new Dictionary<Node, Node>();
            while (root.next != null)
            {
                root = root.next;
                if (!pairs.TryGetValue(root, out var node))
                {
                    node = new Node(root.val);
                    pairs.Add(root, node);
                }
                nodeCopy.next = node;
                nodeCopy = nodeCopy.next;
                if (root.random != null)
                {
                    if (!pairs.TryGetValue(root.random, out var random))
                    {
                        random = new Node(root.random.val);
                        pairs.Add(root.random, random);
                    }
                    nodeCopy.random = random;
                }
            }
            return rootCopy.next;
        }
    }
}
