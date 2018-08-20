using System.Collections.Generic;

namespace LeetCode.Explore.IntermediateAlgorithm.TreeAndDiagram
{
    internal class KthSmallestSolution
    {
        public int KthSmallest(TreeNode root, int k)
        {
            if (root == null)
            {
                return 0;
            }
            int leftSize = CalcTreeSize(root.left);
            if (k == leftSize + 1)
            {
                return root.val;
            }
            else if (leftSize >= k)
            {
                return KthSmallest(root.left, k);
            }
            else
            {
                return KthSmallest(root.right, k - leftSize - 1);
            }
        }

        private int CalcTreeSize(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            return 1 + CalcTreeSize(root.left) + CalcTreeSize(root.right);
        }

        public int KthSmallest1(TreeNode root, int k)
        {
            Stack<TreeNode> stack = new Stack<TreeNode>();
            if (root == null || k <= 0)
            {
                return -1;
            }
            TreeNode p = root;
            while (p.left != null)
            {
                stack.Push(p);
                p = p.left;
            }

            while (k > 0 && (p != null || stack.Count != 0))
            {
                if (p == null)
                {
                    p = stack.Pop();
                    if (--k == 0)
                    {
                        return p.val;
                    }
                    p = p.right;
                }
                else
                {
                    stack.Push(p);
                    p = p.left;
                }
            }
            return 0;
        }
    }
}
