using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Bliz_75;
//Medium
internal class _1448_Count_Good_Nodes_in_Binary_Tree
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    //17 minutes
    public int GoodNodes(TreeNode root)
    {
        int count = 0;
        Count(root,int.MinValue, ref count);
        return count;
    }

    private void Count (TreeNode root, int max, ref int count)
    {
        if (root == null) return;
        if (root.val >= max) count++;

        Count(root.left, Math.Max(root.val, max),ref count);
        Count(root.right, Math.Max(root.val, max), ref count);
    }
}
