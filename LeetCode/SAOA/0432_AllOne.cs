using System.Collections.Generic;

namespace LeetCode.SAOA
{
    internal sealed class AllOne
    {
        private readonly Node _root;
        private readonly Dictionary<string, Node> _nodes;

        public AllOne()
        {
            _root = new Node();
            _root.Prev = _root;
            _root.Next = _root;  // 初始化链表哨兵，下面判断节点的 Next 若为 root，则表示 Next 为空（Prev 同理）
            _nodes = new Dictionary<string, Node>();
        }

        public void Inc(string key)
        {
            if (_nodes.ContainsKey(key))
            {
                Node cur = _nodes[key];
                Node nxt = cur.Next;
                if (nxt == _root || nxt.Count > cur.Count + 1)
                {
                    _nodes[key] = cur.Insert(new Node(key, cur.Count + 1));
                }
                else
                {
                    nxt.Keys.Add(key);
                    _nodes[key] = nxt;
                }
                cur.Keys.Remove(key);
                if (cur.Keys.Count == 0)
                {
                    cur.Remove();
                }
            }
            else
            {  // key 不在链表中
                if (_root.Next == _root || _root.Next.Count > 1)
                {
                    _nodes.Add(key, _root.Insert(new Node(key, 1)));
                }
                else
                {
                    _root.Next.Keys.Add(key);
                    _nodes.Add(key, _root.Next);
                }
            }
        }

        public void Dec(string key)
        {
            Node cur = _nodes[key];
            if (cur.Count == 1)
            {
                // key 仅出现一次，将其移出 nodes
                _nodes.Remove(key);
            }
            else
            {
                Node pre = cur.Prev;
                if (pre == _root || pre.Count < cur.Count - 1)
                {
                    _nodes[key] = cur.Prev.Insert(new Node(key, cur.Count - 1));
                }
                else
                {
                    pre.Keys.Add(key);
                    _nodes[key] = pre;
                }
            }
            cur.Keys.Remove(key);
            if (cur.Keys.Count == 0)
            {
                cur.Remove();
            }
        }

        public string GetMaxKey()
        {
            if (_root.Prev == null)
            {
                return "";
            }
            string maxKey = "";
            foreach (string key in _root.Prev.Keys)
            {
                maxKey = key;
                break;
            }
            return maxKey;
        }

        public string GetMinKey()
        {
            if (_root.Next == null)
            {
                return "";
            }
            string minKey = "";
            foreach (string key in _root.Next.Keys)
            {
                minKey = key;
                break;
            }
            return minKey;
        }

        private sealed class Node
        {
            public Node Prev { get; set; }
            public Node Next { get; set; }
            public ISet<string> Keys { get; set; }
            public int Count { get; set; }

            public Node() : this("", 0)
            {

            }

            public Node(string key, int count)
            {
                this.Count = count;
                Keys = new HashSet<string>
                {
                    key
                };
            }

            public Node Insert(Node node)
            {  // 在 this 后插入 node
                node.Prev = this;
                node.Next = this.Next;
                node.Prev.Next = node;
                node.Next.Prev = node;
                return node;
            }

            public void Remove()
            {
                this.Prev.Next = this.Next;
                this.Next.Prev = this.Prev;
            }
        }
    }
}
