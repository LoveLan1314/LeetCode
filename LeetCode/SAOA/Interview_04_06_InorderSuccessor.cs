using System.Collections.Generic;

namespace LeetCode.SAOA
{
    internal sealed class InorderSuccessorSolution
    {
        public TreeNode InorderSuccessor(TreeNode root, TreeNode p)
        {
            var stack = new Stack<TreeNode>();
            TreeNode prev = null;
            TreeNode curr = root;
            while (stack.Count > 0 || curr != null)
            {
                while (curr != null)
                {
                    stack.Push(curr);
                    curr = curr.left;
                }
                curr = stack.Pop();
                if (prev == p)
                {
                    return curr;
                }
                prev = curr;
                curr = curr.right;
            }
            return null;
        }

        public sealed class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }

    }
}
