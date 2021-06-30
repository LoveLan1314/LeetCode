using System.Collections.Generic;

namespace LeetCode.SAOA
{
    internal sealed class CodecSolution
    {
        public string Serialize(TreeNode root)
        {
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            List<string> result = new List<string>();
            while (queue.Count > 0)
            {
                var node = queue.Dequeue();
                if (node != null)
                {
                    queue.Enqueue(node.left);
                    queue.Enqueue(node.right);
                }
                result.Add(node == null ? "null" : node.val.ToString());
            }
            return string.Join(",", result);
        }

        public TreeNode Deserialize(string data)
        {
            var list = data.Split(",");
            if (list.Length > 0 && list[0] != "null")
            {
                TreeNode root = new TreeNode(int.Parse(list[0]));

                Queue<TreeNode> queue = new Queue<TreeNode>();
                queue.Enqueue(root);
                for (int i = 1; i < list.Length; i += 2)
                {
                    var node = queue.Dequeue();
                    var left = list[i];
                    if (left != "null")
                    {
                        node.left = new TreeNode(int.Parse(left));
                        queue.Enqueue(node.left);
                    }
                    var right = list[i + 1];
                    if (right != "null")
                    {
                        node.right = new TreeNode(int.Parse(right));
                        queue.Enqueue(node.right);
                    }
                }
                return root;
            }
            return null;
        }
    }
}
