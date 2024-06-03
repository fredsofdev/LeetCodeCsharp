using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Top150;
//Medium
internal class _138_Compy_List_with_Random_Pointer
{
    
    public class Node
    {
        public int val;
        public Node next;
        public Node random;

        public Node(int _val)
        {
            val = _val;
            next = null;
            random = null;
        }
    }
    // 60 minutes
    public Node CopyRandomList(Node head)
    {
        Dictionary<Node, Node> pair = new();
        Node copy = new Node(0);
        Node currCopy = copy;
        Node curr = head;
        while (curr != null)
        {
            currCopy.next = new Node(curr.val);
            pair[curr] = currCopy.next;
            currCopy = currCopy.next;
            curr = curr.next;
        }

        foreach (var p in pair)
        {
            if (p.Key.random == null) continue;
            if (pair.TryGetValue(p.Key.random, out Node? random)) p.Value.random = random;
        }

        return copy.next;
    }

    // optimized
    public Node CopyRandomList2(Node head)
    {
        Dictionary<Node, Node> pair = new();
        Node curr = head;
        while (curr != null)
        {
            pair[curr] = new Node(curr.val);
            curr = curr.next;
        }

        curr = head;
        while (curr != null)
        {
            pair[curr].next = curr.next != null ? pair[curr.next]: null;
            pair[curr].random = curr.random != null ? pair[curr.random] : null;
        }

        return pair[head];
    }
}
