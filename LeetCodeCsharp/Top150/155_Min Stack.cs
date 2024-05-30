using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Top150;
//Medium
//17 minutes
public class MinStack
{
    private Node? root = null;
    class Node
    {
        public int val { set; get; }
        public int min { set; get; }
        public Node? next { set; get; }
        public Node(int val, int min)
        {
            this.val = val;
            this.min = min;
        }
    }

    public MinStack()
    {

    }

    public void Push(int val)
    {
        int min = Math.Min(val, root==null? int.MaxValue:root.min);
        var newNode = new Node(val, min);
        newNode.next = root;
        root = newNode;
    }

    public void Pop()
    {
        if (root == null) return;
        root = root.next;
    }

    public int Top()
    {
        return root.val;
    }

    public int GetMin()
    {
        return root.min;
    }
}
