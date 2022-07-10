using System.Collections.Generic;

namespace LeetCode.SAOA
{
    internal sealed class SmallestInfiniteSet
    {
        private readonly LinkedList<int> _list = new LinkedList<int>();
        private readonly Dictionary<int, LinkedListNode<int>> _pairs = new Dictionary<int, LinkedListNode<int>>();

        public SmallestInfiniteSet()
        {
            for (int i = 1; i <= 1000; i++)
            {
                var node = _list.AddLast(i);
                _pairs.Add(i, node);
            }
        }

        public int PopSmallest()
        {
            var node = _list.First;
            _pairs.Remove(node.Value);
            _list.RemoveFirst();
            return node.Value;
        }

        public void AddBack(int num)
        {
            if (!_pairs.ContainsKey(num))
            {
                for (int i = num - 1; i > 0; i--)
                {
                    if (_pairs.TryGetValue(i, out var node))
                    {
                        var newNode = _list.AddAfter(node, num);
                        _pairs.Add(num, newNode);
                        return;
                    }
                }
                var first = _list.AddFirst(num);
                _pairs.Add(num, first);
            }
        }
    }
}
