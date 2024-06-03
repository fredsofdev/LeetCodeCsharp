using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Top150;
//Easy
internal class _141_Linked_List_Cycle
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x)
        {
                val = x;
                next = null;
        }
    }
    //8 minutes
    public bool HasCycle(ListNode head)
    {
        if(head == null) return false;
        HashSet<ListNode> cycle = new HashSet<ListNode>();
        while(head.next != null)
        {
            if(!cycle.Add(head.next)) return true;
            head = head.next;
        }
        return false;
    }

    // Two pointer implementation
    public bool HasCycle1(ListNode head)
    {
        ListNode slow_node = head, fast_node = head;
        while (fast_node != null && fast_node.next != null)
        {
            slow_node = slow_node.next;
            fast_node = fast_node.next.next;
            if (slow_node == fast_node)
                return true;
        }
        return false;
    }
}
