using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Top150;
//Medium
internal class _82_Remove_Duplicates_from_Sorted_List_2
{
    //13 minutes. by copying prev solution and twicking it because both has same approach.
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

    public ListNode DeleteDuplicates(ListNode head)
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
        bool rem = false;
        while (rev != null)
        {
            if (rev.next != null && rev.val == rev.next.val)
            {
                rev = rev.next;
                rem = true;
                continue;
            }
            if (rem)
            {
                rev = rev.next;
                rem = false;
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
