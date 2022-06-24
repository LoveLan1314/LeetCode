using System.Collections.Generic;

namespace LeetCode.SAOA
{
    internal sealed class LargestValuesSolution
    {
        public IList<int> LargestValues(TreeNode root)
        {
            var result = new List<int>();
            var current = new Queue<TreeNode>();
            var next = new Queue<TreeNode>();
            current.Enqueue(root);
            var max = int.MinValue;
            while (current.Count > 0)
            {
                var node = current.Dequeue();
                if (node != null)
                {
                    next.Enqueue(node.left);
                    next.Enqueue(node.right);
                    if (node.val > max)
                    {
                        max = node.val;
                    }
                }
                if (current.Count == 0 && next.Count > 0)
                {
                    current = next;
                    next = new Queue<TreeNode>();
                    result.Add(max);
                    max = int.MinValue;
                }
            }
            return result;
        }
    }
}
