using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Bliz_75;
//Medium
internal class _450_Delete_Node_in_a_BST
{
    //Failed to solve
    public TreeNode DeleteNode(TreeNode root, int key)
    {
        if (root == null) return null;

        if (root.val == key)
        {
            if (root.right == null && root.left == null) return null;
            if (root.right == null) return root.left;
            else if (root.left == null) return root.right;
            else
            {
                var tmp = root.right;
                while(tmp.left!= null) tmp = tmp.left;
                root.val = tmp.val;
                root.right = DeleteNode(root.left, tmp.val);
            }
        }
        if (root.val < key) root.right = DeleteNode(root.right, key);
        else root.left = DeleteNode(root.left, key);
        return root;
    }


  
    
}
