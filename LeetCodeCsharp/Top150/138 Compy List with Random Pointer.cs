using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Top150;
//Medium
internal class _138_Compy_List_with_Random_Pointer
{
    // 60 minutes
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
}
