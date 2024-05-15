using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Week4.BST;

internal class ValidBST
{
    class Node
    {
        public int key;
        public int val;
        public Node? left;
        public Node? right;
        
        public Node(int key, int val)
        {
            this.key = key;
            this.val = val;
        }
    }

    private bool ValidateBST(Node x)
    {
        if (x == null) return true;
        if (x.left != null && x.left.val > x.val) return false;
        if (x.right != null && x.right.val < x.val) return false;

        return ValidateBST(x.left) && ValidateBST(x.right);
    }
}
