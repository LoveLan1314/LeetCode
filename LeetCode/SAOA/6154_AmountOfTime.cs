using System.Collections.Generic;

namespace LeetCode.SAOA
{
    internal sealed class AmountOfTimeSolution
    {
        public int AmountOfTime(TreeNode root, int start)
        {
            var pairs = new Dictionary<int, List<int>>();
            void AddPairs(int start, int to)
            {
                if (pairs.TryGetValue(start, out var listTo))
                {
                    listTo.Add(to);
                }
                else
                {
                    pairs.Add(start, new List<int>() { to });
                }
                if (pairs.TryGetValue(to, out var listStart))
                {
                    listStart.Add(start);
                }
                else
                {
                    pairs.Add(to, new List<int>() { start });
                }
            }
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            var set = new HashSet<int>();
            while (queue.Count > 0)
            {
                var count = queue.Count;
                for (int i = 0; i < count; i++)
                {
                    var node = queue.Dequeue();
                    set.Add(node.val);
                    if (node.left != null)
                    {
                        queue.Enqueue(node.left);
                        AddPairs(node.val, node.left.val);
                    }
                    if (node.right != null)
                    {
                        queue.Enqueue(node.right);
                        AddPairs(node.val, node.right.val);
                    }
                }
            }
            var infectQueue = new Queue<int>();
            infectQueue.Enqueue(start);
            set.Remove(start);
            var time = 0;
            while (set.Count > 0)
            {
                var infectCount = infectQueue.Count;
                for (int i = 0; i < infectCount; i++)
                {
                    var infectValue = infectQueue.Dequeue();
                    if (pairs.TryGetValue(infectValue, out var list))
                    {
                        foreach (var item in list)
                        {
                            if (set.Contains(item))
                            {
                                infectQueue.Enqueue(item);
                                set.Remove(item);
                            }
                        }
                    }
                }
                time++;
            }
            return time;
        }
    }
}
