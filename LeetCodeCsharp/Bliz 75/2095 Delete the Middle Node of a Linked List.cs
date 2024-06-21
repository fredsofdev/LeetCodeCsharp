using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Bliz_75;
//Medium
internal class _2095_Delete_the_Middle_Node_of_a_Linked_List
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    //11 minutes
    public ListNode DeleteMiddle(ListNode head)
    {
        if (head.next == null) return null;
        int count = 0;
        var temp = head;
        while(temp != null)
        {
            count++;
            temp = temp.next;
        }

        count = count / 2;
        temp = head;
        while (temp != null)
        {
            if (count-- == 1)
            {
                temp.next = temp.next.next;
                break;
            }
            temp = temp.next;
        }
        return head;
    }

    //Optimal fast and slow nodes
    public ListNode DeleteMiddle2(ListNode head)
    {
        ListNode fast = head;
        ListNode slow = head;
        ListNode prev = null;
        while (fast != null && fast.next != null)
        {
            fast = fast.next.next;
            prev = slow;
            slow = slow.next;
        }

        if (prev == null) return null;
        prev.next = slow.next;
        return head;
    }

}
