using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.SAOA
{
    internal sealed class LeafSimilarSolution
    {
        public bool LeafSimilar(TreeNode root1, TreeNode root2)
        {
            var seq1 = new List<int>();
            if (root1 != null)
            {
                DFS(root1, seq1);
            }

            var seq2 = new List<int>();
            if (root2 != null)
            {
                DFS(root2, seq2);
            }

            return seq1.SequenceEqual(seq2);
        }

        private void DFS(TreeNode node, IList<int> seq)
        {
            if (node.left == null && node.right == null)
            {
                seq.Add(node.val);
            }
            else
            {
                if (node.left != null)
                {
                    DFS(node.left, seq);
                }
                if (node.right != null)
                {
                    DFS(node.right, seq);
                }
            }
        }
    }
}
