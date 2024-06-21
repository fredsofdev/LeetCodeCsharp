using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Bliz_75;
//Easy
internal class _206_Reverse_LInked_List
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
    //5 minutes
    public ListNode ReverseList(ListNode head)
    {
        if (head == null || head.next == null) return head;

        ListNode curr = null;
        while(head != null)
        {
            var tmp = head.next;
            head.next = curr;
            curr = head;
            head = tmp;
        }

        return curr;
    }
}
