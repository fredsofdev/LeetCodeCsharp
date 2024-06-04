using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Top150;
//Medium
internal class _19_Remove_Nth_Node_From_End_of_List
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
    // 22 minutes
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        ListNode rev = null;
        while (head != null)
        {
            var temp = new ListNode(head.val);
            temp.next = rev;
            rev = temp;
            head = head.next;
        }
        
        ListNode curr = null;
        
        while (rev != null)
        {
            if (--n == 0)
            {
                rev = rev.next;
                continue;
            }
            var temp = new ListNode(rev.val);
            temp.next = curr;
            curr = temp;
            rev = rev.next;
        }

        return curr;
    }
}
