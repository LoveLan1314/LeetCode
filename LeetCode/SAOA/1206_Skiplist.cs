using System;

namespace LeetCode.SAOA
{
    internal sealed class Skiplist
    {
        const int MAX_LEVEL = 32;
        const double P_FACTOR = 0.25;
        private readonly SkiplistNode _head;
        private int _level;
        private readonly Random _random;

        public Skiplist()
        {
            _head = new SkiplistNode(-1, MAX_LEVEL);
            _level = 0;
            _random = new Random();
        }

        public bool Search(int target)
        {
            SkiplistNode curr = _head;
            for (int i = _level - 1; i >= 0; i--)
            {
                /* 找到第 i 层小于且最接近 target 的元素*/
                while (curr.forward[i] != null && curr.forward[i].val < target)
                {
                    curr = curr.forward[i];
                }
            }
            curr = curr.forward[0];
            /* 检测当前元素的值是否等于 target */
            if (curr != null && curr.val == target)
            {
                return true;
            }
            return false;
        }

        public void Add(int num)
        {
            SkiplistNode[] update = new SkiplistNode[MAX_LEVEL];
            Array.Fill(update, _head);
            SkiplistNode curr = _head;
            for (int i = _level - 1; i >= 0; i--)
            {
                /* 找到第 i 层小于且最接近 num 的元素*/
                while (curr.forward[i] != null && curr.forward[i].val < num)
                {
                    curr = curr.forward[i];
                }
                update[i] = curr;
            }
            int lv = RandomLevel();
            _level = Math.Max(_level, lv);
            SkiplistNode newNode = new SkiplistNode(num, lv);
            for (int i = 0; i < lv; i++)
            {
                /* 对第 i 层的状态进行更新，将当前元素的 forward 指向新的节点 */
                newNode.forward[i] = update[i].forward[i];
                update[i].forward[i] = newNode;
            }
        }

        public bool Erase(int num)
        {
            SkiplistNode[] update = new SkiplistNode[MAX_LEVEL];
            SkiplistNode curr = _head;
            for (int i = _level - 1; i >= 0; i--)
            {
                /* 找到第 i 层小于且最接近 num 的元素*/
                while (curr.forward[i] != null && curr.forward[i].val < num)
                {
                    curr = curr.forward[i];
                }
                update[i] = curr;
            }
            curr = curr.forward[0];
            /* 如果值不存在则返回 false */
            if (curr == null || curr.val != num)
            {
                return false;
            }
            for (int i = 0; i < _level; i++)
            {
                if (update[i].forward[i] != curr)
                {
                    break;
                }
                /* 对第 i 层的状态进行更新，将 forward 指向被删除节点的下一跳 */
                update[i].forward[i] = curr.forward[i];
            }
            /* 更新当前的 level */
            while (_level > 1 && _head.forward[_level - 1] == null)
            {
                _level--;
            }
            return true;
        }

        private int RandomLevel()
        {
            int lv = 1;
            /* 随机生成 lv */
            while (_random.NextDouble() < P_FACTOR && lv < MAX_LEVEL)
            {
                lv++;
            }
            return lv;
        }

        private sealed class SkiplistNode
        {
            public int val;
            public SkiplistNode[] forward;

            public SkiplistNode(int val, int maxLevel)
            {
                this.val = val;
                forward = new SkiplistNode[maxLevel];
            }
        }
    }
}
