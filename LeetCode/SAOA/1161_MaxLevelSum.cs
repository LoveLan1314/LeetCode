using System.Collections.Generic;

namespace LeetCode.SAOA
{
    internal sealed class MaxLevelSumSolution
    {
        public int MaxLevelSum(TreeNode root)
        {
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            var nextQueue = new Queue<TreeNode>();
            var level = 1;
            var max = int.MinValue;
            var sum = 0;
            var maxLevel = -1;
            while (queue.Count > 0)
            {
                var node = queue.Dequeue();
                sum += node.val;
                if (node.left != null)
                {
                    nextQueue.Enqueue(node.left);
                }
                if (node.right != null)
                {
                    nextQueue.Enqueue(node.right);
                }
                if (queue.Count == 0)
                {
                    if (sum > max)
                    {
                        maxLevel = level;
                        max = sum;
                    }
                    sum = 0;
                    queue = nextQueue; 
                    nextQueue = new Queue<TreeNode>();
                    level++;
                }
            }
            return maxLevel;
        }
    }
}
