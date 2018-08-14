using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Explore.IntermediateAlgorithm.TreeAndDiagram
{
    class InorderTraversalSolution
    {
        public IList<int> InorderTraversal(TreeNode root)
        {
            List<int> result = new List<int>();
            if (root != null)
            {
                result.AddRange(InorderTraversal(root.left));
                result.Add(root.val);
                result.AddRange(InorderTraversal(root.right));
            }
            return result;
        }

        public IList<int> InorderTraversal1(TreeNode root)
        {
            List<int> result = new List<int>();
            Stack<TreeNode> s = new Stack<TreeNode>();
            TreeNode node = root;
            while(node != null || s.Count != 0)
            {
                while(node != null)
                {
                    s.Push(node);
                    node = node.left;
                }
                if(s.Count != 0)
                {
                    node = s.Pop();
                    result.Add(node.val);
                    node = node.right;
                }
            }
            return result;
        }
    }
}
