using System.Collections.Generic;

namespace LeetCode.SAOA
{
    internal sealed class DeepestLeavesSumSolution
    {
        public int DeepestLeavesSum(TreeNode root)
        {
            var sum = 0;
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                sum = 0;
                var size = queue.Count;
                for (int i = 0; i < size; i++)
                {
                    var node = queue.Dequeue();
                    sum += node.val;
                    if (node.left != null)
                    {
                        queue.Enqueue(node.left);
                    }
                    if (node.right != null)
                    {
                        queue.Enqueue(node.right);
                    }
                }
            }
            return sum;
        }
    }
}
