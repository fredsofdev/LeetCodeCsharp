using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Top150;
//Medium
internal class _106_Construct_Binanry_Tree_From_Inorder_and_Preorder_Traversal
{
    //56 minutes after getting looking at intuition
    public TreeNode BuildTree(int[] inorder, int[] postorder)
    {
        if (postorder is null || !postorder.Any() ||
           inorder is null || !inorder.Any()) return null;
        int last = postorder.Length - 1;
        int middle = Array.IndexOf(inorder, postorder[last]);
        while (middle == -1 && last != 0) middle = Array.IndexOf(inorder, postorder[--last]);
        TreeNode root = new TreeNode(postorder[last]);
        
        root.left = BuildTree(inorder[0..middle], postorder[..last]);
        root.right = BuildTree(inorder[(middle + 1)..], postorder[..last]);

        return root;
    }
}
