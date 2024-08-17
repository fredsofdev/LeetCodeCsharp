using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Top150;
//Medium
internal class _114_Flatten_Binary_Tree_to_Linked_List
{
    //19 minutes
    public void Flatten(TreeNode root)
    {
        Stack<TreeNode> stack = new Stack<TreeNode>();
        DFS(root, stack);
        TreeNode prev = null;
        while(stack.Count > 0)
        {
            TreeNode node = stack.Pop();
            node.right = prev;
            prev = node;
        }
    }

    private void DFS(TreeNode root, Stack<TreeNode> stack)
    {
        if (root == null) return;
        stack.Push(root);
        DFS(root.left, stack);
        DFS(root.right, stack);
        root.left = null;
    }

}
