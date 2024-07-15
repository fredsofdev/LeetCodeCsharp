using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Top150;

internal class _124_Binary_Tree_Maximum_Path_Sum
{
    public int MaxPathSum(TreeNode root)
    {
        if (root == null) return 0;



    }

    private int GetMaxChild(TreeNode root, int sum)
    {
        if (root == null) return 0;
        sum += root.val;
        
        int left = GetMaxChild(root.left, 0);
        int right = GetMaxChild(root.right, 0);

        return Math.Max(GetMaxChild(root.left, sum), 
            GetMaxChild(root.right, sum));
    } 
}
