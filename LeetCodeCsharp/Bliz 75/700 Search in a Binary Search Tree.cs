using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Bliz_75;
//Easy
internal class _700_Search_in_a_Binary_Search_Tree
{
    //5 minutes
    public TreeNode SearchBST2(TreeNode root, int val)
    {
        while (root != null)
        {
            if (root.val == val) break;
            if (root.val < val) root = root.right;
            else root = root.left;
        }
        return root;
    }
    // Recursive approach
    public TreeNode SearchBST(TreeNode root, int val)
    {
        if (root == null) return null;

        if (root.val == val) return root;

        if(root.val < val) return SearchBST(root.right, val);
        else return SearchBST(root.left, val);
    }
}
