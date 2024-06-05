using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Top150;
//Easy
internal class _226_Invert_Binary_Tree
{
    //5 minutes
    public TreeNode InvertTree(TreeNode root)
    {
        if (root == null) return root;
        var tmp = root.left;
        root.left = root.right;
        root.right = tmp;
        InvertTree(root.left);
        InvertTree(root.right);
        return root;
    }
}
