using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Explore.PrimaryAlgorithm.Tree
{
    class LevelOrderSolution
    {
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            TreeNode temp = new TreeNode('#');
            List<int> list = new List<int>();
            IList<IList<int>> result = new List<IList<int>>();
            Queue<TreeNode> nodes = new Queue<TreeNode>();
            if (root == null)
            {
                return result;
            }
            nodes.Enqueue(root);
            nodes.Enqueue(temp);
            while(nodes.Count != 0)
            {
                var node = nodes.Dequeue();
                if(node == temp)
                {
                    if(nodes.Count != 0)
                    {
                        nodes.Enqueue(temp);
                    }
                    result.Add(list);
                    list = new List<int>();
                    continue;
                }
                list.Add(node.val);
                if(node.left != null)
                {
                    nodes.Enqueue(node.left);
                }
                if(node.right != null)
                {
                    nodes.Enqueue(node.right);
                }
            }
            return result;
        }
    }
}
