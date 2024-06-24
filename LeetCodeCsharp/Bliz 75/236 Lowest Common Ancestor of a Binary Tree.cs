using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Bliz_75;
//Medium
internal class _236_Lowest_Common_Ancestor_of_a_Binary_Tree
{
    TreeNode Common = null;
    int count = 0;

    //26 minutes
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
    {
        if (root == null) return null; 
        if (root.val == p.val || root.val == q.val) count++;
        if (Common == null && count == 1) Common = root;
        LowestCommonAncestor(root.left, p, q);
        if (Common == null && count == 1) Common = root;
        LowestCommonAncestor(root.right, p, q);
        if (Common == root && count == 1) Common = null;
        return Common;
    }
}
