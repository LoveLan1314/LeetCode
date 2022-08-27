using System;
using System.Collections.Generic;

namespace LeetCode.SAOA
{
    internal sealed class WidthOfBinaryTreeSolution
    {
        public int WidthOfBinaryTree(TreeNode root)
        {
            int res = 1;
            var arr = new List<Tuple<TreeNode, int>>
            {
                new Tuple<TreeNode, int>(root, 1)
            };
            while (arr.Count > 0)
            {
                var tmp = new List<Tuple<TreeNode, int>>();
                foreach (Tuple<TreeNode, int> pair in arr)
                {
                    TreeNode node = pair.Item1;
                    int index = pair.Item2;
                    if (node.left != null)
                    {
                        tmp.Add(new Tuple<TreeNode, int>(node.left, index * 2));
                    }
                    if (node.right != null)
                    {
                        tmp.Add(new Tuple<TreeNode, int>(node.right, index * 2 + 1));
                    }
                }
                res = Math.Max(res, arr[^1].Item2 - arr[0].Item2 + 1);
                arr = tmp;
            }
            return res;
        }
    }
}
