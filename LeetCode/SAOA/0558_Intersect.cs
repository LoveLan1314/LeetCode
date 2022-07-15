namespace LeetCode.SAOA
{
    internal sealed class IntersectSolution
    {
        public Node Intersect(Node quadTree1, Node quadTree2)
        {
            if (quadTree1.isLeaf)
            {
                if (quadTree1.val)
                {
                    return new Node(true, true);
                }
                return new Node(quadTree2.val, quadTree2.isLeaf, quadTree2.topLeft, quadTree2.topRight, quadTree2.bottomLeft, quadTree2.bottomRight);
            }
            if (quadTree2.isLeaf)
            {
                return Intersect(quadTree2, quadTree1);
            }
            Node o1 = Intersect(quadTree1.topLeft, quadTree2.topLeft);
            Node o2 = Intersect(quadTree1.topRight, quadTree2.topRight);
            Node o3 = Intersect(quadTree1.bottomLeft, quadTree2.bottomLeft);
            Node o4 = Intersect(quadTree1.bottomRight, quadTree2.bottomRight);
            if (o1.isLeaf && o2.isLeaf && o3.isLeaf && o4.isLeaf && o1.val == o2.val && o1.val == o3.val && o1.val == o4.val)
            {
                return new Node(o1.val, true);
            }
            return new Node(false, false, o1, o2, o3, o4);
        }

        public class Node
        {
            public bool val;
            public bool isLeaf;
            public Node topLeft;
            public Node topRight;
            public Node bottomLeft;
            public Node bottomRight;

            public Node() { }
            public Node(bool _val, bool _isLeaf, Node _topLeft, Node _topRight, Node _bottomLeft, Node _bottomRight)
            {
                val = _val;
                isLeaf = _isLeaf;
                topLeft = _topLeft;
                topRight = _topRight;
                bottomLeft = _bottomLeft;
                bottomRight = _bottomRight;
            }

            public Node(bool _val, bool _isLeaf) : this(_val, _isLeaf, null, null, null, null)
            {

            }
        }
    }
}
