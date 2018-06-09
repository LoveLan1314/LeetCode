using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Explore.PrimaryAlgorithm.Tree
{
    class MaxDepthSolution
    {
        public int MaxDepth(TreeNode root)
        {
            return GetTreeDepth(root, 0);
        }
        public int GetTreeDepth(TreeNode node,int deep)
        {
            if(node == null)
            {
                return deep;
            }
            deep++;
            return Math.Max(GetTreeDepth(node.left, deep), GetTreeDepth(node.right, deep));
        }
    }
}
