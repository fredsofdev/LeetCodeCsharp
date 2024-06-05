using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Top150;
//Easy
internal class _104_Maximum_Depth_of_Binary_Tree
{
    //7 minutes
    public int MaxDepth(TreeNode root)
    {
        return Depth(root, 0);
    }

    private int Depth(TreeNode node, int depth)
    {
        if (node == null) return depth;
        depth++;
        return Math.Max(Depth(node.left, depth), Depth(node.right, depth));
    }
}
