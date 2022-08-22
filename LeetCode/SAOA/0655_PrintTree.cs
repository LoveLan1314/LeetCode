using System;
using System.Collections.Generic;

namespace LeetCode.SAOA
{
    internal sealed class PrintTreeSolution
    {
        public IList<IList<string>> PrintTree(TreeNode root)
        {
            var height = CalcDepth(root);
            var m = height + 1;
            var n = (1 << (height + 1)) - 1;
            var res = new List<IList<string>>();
            for (int i = 0; i < m; i++)
            {
                var row = new List<string>();
                for (int j = 0; j < n; j++)
                {
                    row.Add("");
                }
                res.Add(row);
            }
            DFS(res, root, 0, (n - 1) / 2, height);
            return res;
        }

        private int CalcDepth(TreeNode root)
        {
            var h = 0;
            if (root.left != null)
            {
                h = Math.Max(h, CalcDepth(root.left) + 1);
            }
            if (root.right != null)
            {
                h = Math.Max(h, CalcDepth(root.right) + 1);
            }
            return h;
        }

        private void DFS(IList<IList<string>> res, TreeNode root, int r, int c, int height)
        {
            res[r][c] = root.val.ToString();
            if (root.left != null)
            {
                DFS(res, root.left, r + 1, c - (1 << (height - r - 1)), height);
            }
            if (root.right != null)
            {
                DFS(res, root.right, r + 1, c + (1 << (height - r - 1)), height);
            }
        }
    }
}
