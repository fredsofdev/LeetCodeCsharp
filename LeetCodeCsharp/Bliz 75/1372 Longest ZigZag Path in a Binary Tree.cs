using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Bliz_75;
//Medium
internal class _1372_Longest_ZigZag_Path_in_a_Binary_Tree
{
    int max = 0;
    //42 minutes
    public int LongestZigZag(TreeNode root)
    {
        max = 0;
        if(root.left != null) zigzag(root.left, 1, true);
        if(root.right != null) zigzag(root.right, 1, false);
        return max;
    }

    private void zigzag(TreeNode root, int count, bool isLeft)
    {
        max = Math.Max(max, count);
        if (root == null) return;

        if (root.left != null) zigzag(root.left, isLeft ? 0 : count + 1, true);
        if (root.right != null) zigzag(root.right, isLeft ? count + 1 : 0, false);
    }
}
