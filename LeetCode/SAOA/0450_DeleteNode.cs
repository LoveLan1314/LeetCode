﻿namespace LeetCode.SAOA
{
    internal sealed class DeleteNodeSolution
    {
        public TreeNode DeleteNode(TreeNode root, int key)
        {
            if (root == null)
            {
                return null;
            }
            if (root.val > key)
            {
                root.left = DeleteNode(root.left, key);
                return root;
            }
            if (root.val < key)
            {
                root.right = DeleteNode(root.right, key);
                return root;
            }
            if (root.val == key)
            {
                if (root.left == null && root.right == null)
                {
                    return null;
                }
                if (root.right == null)
                {
                    return root.left;
                }
                if (root.left == null)
                {
                    return root.right;
                }
                TreeNode successor = root.right;
                while (successor.left != null)
                {
                    successor = successor.left;
                }
                root.right = DeleteNode(root.right, successor.val);
                successor.right = root.right;
                successor.left = root.left;
                return successor;
            }
            return root;
        }
    }
}
