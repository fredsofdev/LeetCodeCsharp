using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Top150
{
    internal class _106_Construct_Binanry_Tree_From_Inorder_and_Preorder_Traversal
    {
        public TreeNode BuildTree(int[] inorder, int[] preorder)
        {
            if (preorder is null || !preorder.Any() ||
               inorder is null || !inorder.Any()) return null;

            TreeNode root = new TreeNode(preorder[0]);
            int middle = Array.IndexOf(inorder, preorder[0]);
            root.left = BuildTree(preorder[1..(middle + 1)], inorder[..middle]);
            root.right = BuildTree(preorder[(middle + 1)..], inorder[(middle + 1)..]);

            return root;
        }
    }
}
