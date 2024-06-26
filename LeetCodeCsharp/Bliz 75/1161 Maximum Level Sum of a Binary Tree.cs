using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Bliz_75;
//Medium
internal class _1161_Maximum_Level_Sum_of_a_Binary_Tree
{
    //13 minutes
    public int MaxLevelSum(TreeNode root)
    {
        int max = int.MinValue, level = 0, current = 0;

        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        while (queue.Count > 0)
        {
            current++;

            int count = queue.Count;
            int sum = 0;
            
            while (count-- > 0)
            {
                var node = queue.Dequeue();

                if(node.left != null) queue.Enqueue(node.left);
                if(node.right != null) queue.Enqueue(node.right);

                sum += node.val;
            }

            if (sum > max)
            {
                level = current;
                max = sum;
            }
        }
        return level;

    }
}
