using System;
using System.Collections.Generic;

namespace LeetCode.SAOA
{
    internal sealed class FindDuplicateSubtreesSolution
    {
        private readonly Dictionary<string, Tuple<TreeNode, int>> seen = new Dictionary<string, Tuple<TreeNode, int>>();
        private readonly ISet<TreeNode> repeat = new HashSet<TreeNode>();
        int idx = 0;

        public IList<TreeNode> FindDuplicateSubtrees(TreeNode root)
        {
            DFS(root);
            return new List<TreeNode>(repeat);
        }

        private int DFS(TreeNode node)
        {
            if (node == null)
            {
                return 0;
            }
            var tri = new Tuple<int, int, int>(node.val, DFS(node.left), DFS(node.right));
            string hash = tri.ToString();
            if (seen.ContainsKey(hash))
            {
                Tuple<TreeNode, int> pair = seen[hash];
                repeat.Add(pair.Item1);
                return pair.Item2;
            }
            else
            {
                seen.Add(hash, new Tuple<TreeNode, int>(node, ++idx));
                return idx;
            }
        }
    }
}
