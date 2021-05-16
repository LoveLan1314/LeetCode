using System;

namespace LeetCode.SAOA
{
    internal sealed class FindMaximumXORSolution
    {
        private readonly Trie _root = new Trie();
        const int HIGH_BIT = 30;

        public int FindMaximumXOR(int[] nums)
        {
            int n = nums.Length;
            int x = 0;
            for (int i = 1; i < n; ++i)
            {
                // 将 nums[i-1] 放入字典树，此时 nums[0 .. i-1] 都在字典树中
                Add(nums[i - 1]);
                // 将 nums[i] 看作 ai，找出最大的 x 更新答案
                x = Math.Max(x, Check(nums[i]));
            }
            return x;
        }

        private void Add(int num)
        {
            Trie cur = _root;
            for (int i = HIGH_BIT; i >= 0; i--)
            {
                int bit = (num >> i) & 1;
                if (bit == 0)
                {
                    if (cur.left == null)
                    {
                        cur.left = new Trie();
                    }
                    cur = cur.left;
                }
                else
                {
                    if (cur.right == null)
                    {
                        cur.right = new Trie();
                    }
                    cur = cur.right;
                }
            }
        }

        private int Check(int num)
        {
            Trie cur = _root;
            int x = 0;
            for (int i = HIGH_BIT; i >= 0; i--)
            {
                int bit = (num >> i) & 1;
                if (bit == 0)
                {
                    if (cur.right != null)
                    {
                        cur = cur.right;
                        x = x * 2 + 1;
                    }
                    else
                    {
                        cur = cur.left;
                        x *= 2;
                    }
                }
                else
                {
                    if (cur.left != null)
                    {
                        cur = cur.left;
                        x = x * 2 + 1;
                    }
                    else
                    {
                        cur = cur.right;
                        x *= 2;
                    }
                }
            }
            return x;
        }

        /// <summary>
        /// 字典树
        /// 类似于前缀树
        /// </summary>
        private sealed class Trie
        {
            //左子树指向表示0的子节点
            public Trie left = null;
            //右子树指向表示1的子节点
            public Trie right = null;
        }
    }
}
