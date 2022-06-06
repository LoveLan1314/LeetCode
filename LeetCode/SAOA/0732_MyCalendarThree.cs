using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.SAOA
{
    internal sealed class MyCalendarThree
    {
        private readonly Dictionary<int, int[]> tree;

        public MyCalendarThree()
        {
            tree = new Dictionary<int, int[]>();
        }

        public int Book(int start, int end)
        {
            Update(start, end - 1, 0, 1000000000, 1);
            return tree[1][0];
        }

        private void Update(int start, int end, int l, int r, int idx)
        {
            if (r < start || end < l)
            {
                return;
            }
            if (start <= l && r <= end)
            {
                if (!tree.ContainsKey(idx))
                {
                    tree.Add(idx, new int[2]);
                }
                tree[idx][0]++;
                tree[idx][1]++;
            }
            else
            {
                int mid = (l + r) >> 1;
                Update(start, end, l, mid, 2 * idx);
                Update(start, end, mid + 1, r, 2 * idx + 1);
                if (!tree.ContainsKey(idx))
                {
                    tree.Add(idx, new int[2]);
                }
                if (!tree.ContainsKey(2 * idx))
                {
                    tree.Add(2 * idx, new int[2]);
                }
                if (!tree.ContainsKey(2 * idx + 1))
                {
                    tree.Add(2 * idx + 1, new int[2]);
                }
                tree[idx][0] = tree[idx][1] + Math.Max(tree[2 * idx][0], tree[2 * idx + 1][0]);
            }
        }
    }
}
