using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Top150;
//Medium
internal class _92__Reverse_Linked_List_2
{
    //60 minutes
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

    public ListNode ReverseBetween(ListNode head, int left, int right)
    {
        int len = right - left;
        if (len == 0) return head;
        var curr = head;
        int count = 1;
        ListNode? start = null, end = null, leftN = null;
        while (curr != null)
        {
            if (count == left - 1) leftN = curr;
            if (count >= left)
            {
                var copy = new ListNode(curr.val);
                curr.next = start;
                start = copy;
                if (count == left) end = start;
            }
            if (count == right)
            {
                if (leftN != null) leftN.next = start;
                else head = start;
                end.next = curr.next;
                break;
            }

            count++;
            curr = curr.next;
        }
        return head;
    }
}
