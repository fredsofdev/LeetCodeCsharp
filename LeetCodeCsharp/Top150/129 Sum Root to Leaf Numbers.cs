using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Top150;
//Medium 5 minutes
internal class _129_Sum_Root_to_Leaf_Numbers
{
    
    public int SumNumbers(TreeNode root)
    {
        return path(root, 0);
    }

    private int path(TreeNode root, int num)
    {
        if (root == null) return 0;
        num = (num * 10) + root.val;
        if(root.left == null && root.right == null)
        {
            return num;
        }

        return path(root.left, num) + path(root.right, num);
    }
}
