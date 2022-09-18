using System.Collections.Generic;

namespace LeetCode.SAOA
{
    internal sealed class ReverseOddLevelsSolution
    {
        public TreeNode ReverseOddLevels(TreeNode root)
        {
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            var level = 0;
            while (queue.Count > 0)
            {
                var count = queue.Count;
                var list = new List<TreeNode>(count);
                for (int i = 0; i < count; i++)
                {
                    var node = queue.Dequeue();
                    list.Add(node);
                    if (node.left != null)
                    {
                        queue.Enqueue(node.left);
                    }
                    if (node.right != null)
                    {
                        queue.Enqueue(node.right);
                    }
                }
                if (level % 2 == 1)
                {
                    for (int i = 0; i < list.Count / 2; i++)
                    {
                        var temp = list[i].val;
                        list[i].val = list[list.Count - i - 1].val;
                        list[list.Count - i - 1].val = temp;
                    }
                }
                level++;
            }
            return root;
        }
    }
}
