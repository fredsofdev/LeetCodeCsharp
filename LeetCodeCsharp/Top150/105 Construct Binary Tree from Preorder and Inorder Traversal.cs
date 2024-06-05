using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Top150;
//Medium
internal class _105_Construct_Binary_Tree_from_Preorder_and_Inorder_Traversal
{
    //Failed to solve
    public TreeNode BuildTree(int[] preorder, int[] inorder)
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
