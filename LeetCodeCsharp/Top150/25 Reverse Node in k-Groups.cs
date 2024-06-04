using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Top150;
//Hard
internal class _25_Reverse_Node_in_k_Groups
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
    //45 minutes
    public ListNode ReverseKGroup(ListNode head, int k)
    {
        if (k == 1) return head;
        ListNode endHolder = null;
        ListNode end = null;
        ListNode result = null;
        var curr = head;
        int count = 1;
        ListNode currStart = null;
        ListNode rev = null;
        while (curr != null)
        {
            var node = new ListNode(curr.val, rev);
            rev = node;
            if (count % k == 1)
            {
                endHolder = rev;
                currStart = curr;
            }
            if (count % k == 0)
            {
                if (end != null) end.next = rev;
                else result = rev;
                rev = null;
                end = endHolder;
            }
            if (curr.next == null && count % k != 0)
            {
                if (end != null) end.next = currStart;
            }
            count++;
            curr = curr.next;
        }
        return result;
    }
}
