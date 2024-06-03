using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Top150;

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

    public Node CopyRandomList(Node head)
    {
        if (head == null) return null;
        Node copy = new Node(head.val);
        Node copyP = copy;
        Node curr = head.next;
        while (curr != null)
        {
            copyP.next = new Node(curr.val);
            copyP = copyP.next;
            curr = curr.next;
        }

        curr = copy;
        while (curr != null || head != null)
        {

            if (head.random == null)
            {
                head = head.next;
                curr = curr.next;
                continue;
            }
            Console.WriteLine(head.random.val);
            Node find = curr;
            while (head.random.val != find.val)
                find = find.next;
            
            curr.random = find;
            head = head.next;
            curr = curr.next;
        }
        return copy;
    }
}
