using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Bliz_75;
//Medium
internal class _199_Binary_Tree_Right_Side_View
{
    //30 minutes
    public IList<int> RightSideView(TreeNode root)
    {
        List<int> result = new List<int>(); 
        if(root == null) return result;
        Queue<TreeNode> queue = new Queue<TreeNode>();
        Queue<TreeNode> level = new();
        queue.Enqueue(root);
        while (queue.Count > 0)
        {
            TreeNode node = queue.Dequeue();
            if(node.left != null) level.Enqueue(node.left);
            if (node.right != null) level.Enqueue(node.right);
            if (queue.Count == 0)
            {
                result.Add(node.val);
                while(level.Count > 0) queue.Enqueue(level.Dequeue());
            }
        }
        return result;
    }
    //Optimal
    public IList<int> RightSideView2(TreeNode root)
    {
        List<int> result = new List<int>();
        if (root == null) return result;
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        while (queue.Count > 0)
        {
            int count = queue.Count;
            TreeNode node = null;
            while (count-- > 0)
            {
                node = queue.Dequeue();
                if (node.left != null) queue.Enqueue(node.left);
                if (node.right != null) queue.Enqueue(node.right);
            }
            result.Add(node.val);
        }
        return result;
    }
}
