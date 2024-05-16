using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Week4;

internal class TreeNode
{
    
    public int key;
    public int val;
    public TreeNode? left;
    public TreeNode? right;

    public TreeNode(int key, int val)
    {
        this.key = key;
        this.val = val;
    }
    
}
