using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Top150;
//Easy
internal class _101_Symmetric_Tree
{
    //8 minutes
    public bool IsSymmetric(TreeNode root)
    {
        return IsSameTree(root.left, root.right);
    }

    private bool IsSameTree(TreeNode p, TreeNode q)
    {
        if (p == null && q == null) return true;
        if (p == null || q == null) return false;
        if (p.val != q.val) return false;
        return IsSameTree(p.left, q.right) && IsSameTree(p.right, q.left);
    }
}
