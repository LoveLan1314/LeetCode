using System.Collections.Generic;
using System.Text;

namespace LeetCode.Explore.IntermediateAlgorithm.Design
{
    internal class Codec
    {
        public string Serialize(TreeNode root)
        {
            StringBuilder sb = new StringBuilder();
            SerializeCore(root, sb);
            return sb.ToString();
        }

        private void SerializeCore(TreeNode root, StringBuilder sb)
        {
            if (root == null)
            {
                sb.Append("# ");
                return;
            }
            sb.Append($"{root.val} ");
            SerializeCore(root.left, sb);
            SerializeCore(root.right, sb);
        }

        public TreeNode Deserialize(string data)
        {
            if (data == "# " || data == "")
            {
                return null;
            }

            List<string> list = new List<string>(data.Split(' '));

            int n = 0;
            TreeNode root = DeserializeCore(list, ref n);
            return root;
        }

        private TreeNode DeserializeCore(List<string> data, ref int n)//这个ref很重要
        {
            TreeNode node = null;
            if (data[n] == "#")
            {
                return node;
            }
            else
            {
                node = new TreeNode(int.Parse(data[n]));
            }

            TreeNode left = null;
            TreeNode right = null;
            n++;
            if (n <= data.Count - 2)
            {
                left = DeserializeCore(data, ref n);
                n++;
                right = DeserializeCore(data, ref n);
            }

            node.left = left;
            node.right = right;

            return node;
        }
    }
}
