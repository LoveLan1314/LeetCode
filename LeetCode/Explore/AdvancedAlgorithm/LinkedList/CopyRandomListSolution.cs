using System.Collections.Generic;

namespace LeetCode.Explore.AdvancedAlgorithm.LinkedList
{
    public class Node
    {
        public int val;
        public Node next;
        public Node random;

        public Node() { }
        public Node(int _val, Node _next, Node _random)
        {
            val = _val;
            next = _next;
            random = _random;
        }
    }

    internal class CopyRandomListSolution
    {
        public Node CopyRandomList(Node head)
        {
            if (head == null)
            {
                return null;
            }
            Node res = new Node()
            {
                val = head.val
            };
            Node node = res;
            Node cur = head.next;
            Dictionary<Node, Node> pairs = new Dictionary<Node, Node>
            {
                { head, res }
            };
            while (cur != null)
            {
                Node tmp = new Node()
                {
                    val = cur.val
                };
                node.next = tmp;
                pairs.Add(cur, tmp);
                node = node.next;
                cur = cur.next;
            }
            node = res;
            cur = head;
            while (node != null)
            {
                node.random = cur.random != null ? pairs[cur.random] : null;
                node = node.next;
                cur = cur.next;
            }
            return res;
        }
    }
}
