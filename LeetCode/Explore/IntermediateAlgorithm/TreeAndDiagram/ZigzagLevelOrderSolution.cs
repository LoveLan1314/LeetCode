using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Explore.IntermediateAlgorithm.TreeAndDiagram
{
    class ZigzagLevelOrderSolution
    {
        public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
        {
            List<IList<int>> result = new List<IList<int>>();
            if (root == null)
            {
                return result;
            }
            bool reverseFlag = false;
            //此处使用Queue<TreeNode>会超时
            List<TreeNode> queue = new List<TreeNode>
            {
                root
            };
            while (queue.Count != 0)
            {
                int count = queue.Count;
                List<int> line = new List<int>();
                while (count-- > 0)
                {
                    TreeNode temp = queue[0];
                    queue.RemoveAt(0);
                    line.Add(temp.val);
                    if(temp.left != null)
                    {
                        queue.Add(temp.left);
                    }
                    if(temp.right != null)
                    {
                        queue.Add(temp.right);
                    }
                }
                if (reverseFlag)
                {
                    line.Reverse();
                }
                reverseFlag = !reverseFlag;
                result.Add(line);
            }
            return result;
        }
    }
}
