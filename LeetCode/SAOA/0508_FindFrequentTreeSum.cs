using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.SAOA
{
    internal sealed class FindFrequentTreeSumSolution
    {
        private readonly Dictionary<int, int> cnt = new Dictionary<int, int>();
        private int maxCnt = 0;

        public int[] FindFrequentTreeSum(TreeNode root)
        {
            DFS(root);
            IList<int> ans = new List<int>();
            foreach (KeyValuePair<int, int> pair in cnt)
            {
                int s = pair.Key, c = pair.Value;
                if (c == maxCnt)
                {
                    ans.Add(s);
                }
            }
            return ans.ToArray();
        }

        private int DFS(TreeNode node)
        {
            if (node == null)
            {
                return 0;
            }
            int sum = node.val + DFS(node.left) + DFS(node.right);
            if (!cnt.ContainsKey(sum))
            {
                cnt.Add(sum, 0);
            }
            maxCnt = Math.Max(maxCnt, ++cnt[sum]);
            return sum;
        }
    }
}
