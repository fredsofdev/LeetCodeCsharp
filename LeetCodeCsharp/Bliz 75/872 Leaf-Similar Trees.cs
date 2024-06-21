using LeetCodeCsharp.Top150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Bliz_75;

internal class _872_Leaf_Similar_Trees
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

    public bool LeafSimilar(TreeNode root1, TreeNode root2)
    {
        var root1En = DFS(root1).ToArray();
        var root2En = DFS(root2).ToArray();
        int maxLeng = Math.Max(root1En.Length, root2En.Length);
        for(int i = 0; i < maxLeng; i++)
        {
            if(i >= root1En.Length || i >= root1En.Length) return false;

            if (root1En[i] != root2En[i]) return false; 
        }
        return true;
    }

    private IEnumerable<int> DFS(TreeNode root)
    {
        if(root == null) yield break;

        if (root.left == null && root.right == null) {
            yield return root.val;
        }
        foreach (int l in DFS(root.left)) { yield return l; }
        foreach (int r in DFS(root.right)) {  yield return r; }
    }

    public bool LeafSimilar2(TreeNode root1, TreeNode root2)
    {
        bool isSame = false;
        if (root1.left == null && root2.left != null) isSame = LeafSimilar2(root1, root2.left);
        else if(root1.left != null && root2.left == null) isSame = LeafSimilar2(root1.left, root2);
        else isSame = root1.val == root2.val;

        if (root1.right == null && root2.right != null) isSame = isSame && LeafSimilar2(root1, root2.right);
        else if (root1.right != null && root2.right == null) isSame = isSame && LeafSimilar2(root1.right, root2);
        else isSame = root1.val == root2.val;

        return isSame;
    }
}
