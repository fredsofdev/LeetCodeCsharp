using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Bliz_75;
//Medium
internal class _437_Path_Sum_3
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

    List<int> list = new();
    int count = 0;

    public int PathSum(TreeNode root, int targetSum)
    {
        count = 0;
        if (count == targetSum) return 0;
        track(root, 0, targetSum);
        list.Clear();
        return count;
    }
    //2 hours, because i did not read description correctly that sum can exceed max int
    private void track(TreeNode root, double sum, int targetSum)
    {
        if (root == null) return;

        sum += root.val;
        
        if (sum == targetSum) count++;

        double tmp = sum;
        int i = 0;
        while (i < list.Count)
        {
            Console.WriteLine($"{root.val} => {tmp}");
            tmp -= list[i++];
            if (tmp == targetSum) count++;
        }

        list.Add(root.val);
        track(root.left, sum, targetSum);
        track(root.right, sum, targetSum);
        list.RemoveAt(list.Count - 1);
    }
}
