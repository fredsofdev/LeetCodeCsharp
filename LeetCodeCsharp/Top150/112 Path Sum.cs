using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Top150;

internal class _112_Path_Sum
{
    public bool HasPathSum2(TreeNode root, int targetSum)
    {
        return _hasPathSum(root, 0, targetSum);
    }

    private bool _hasPathSum(TreeNode root, int sum, int targetSum)
    {
        if (root == null) return false;
        sum += root.val;
        if (root.left == null 
            && root.right == null
            && sum == targetSum) return true;

        return _hasPathSum(root.left, sum, targetSum)
            || _hasPathSum(root.right, sum, targetSum);
    }


    public bool HasPathSum(TreeNode root, int targetSum)
    {
        if(root == null) return false;

        if (root.left == null
            && root.right == null
            && root.val == targetSum) return true;

        targetSum -= root.val;
        return HasPathSum(root.left, targetSum)
            || HasPathSum(root.right, targetSum);
    }
}
