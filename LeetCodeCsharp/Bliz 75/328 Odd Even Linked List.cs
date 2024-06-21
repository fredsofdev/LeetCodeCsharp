using LeetCodeCsharp.Top150;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace LeetCodeCsharp.Bliz_75;
//Medium
internal class _328_Odd_Even_Linked_List
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
    //40 minutes
    public ListNode OddEvenList(ListNode head)
    {
        ListNode evens = head;
        ListNode odds = null;
        while (evens != null && evens.next != null)
        {
            ListNode tmp = evens.next.next;
            evens.next.next = odds;
            odds = evens.next;
            if (tmp == null) break;
            evens.next = tmp;
            evens = evens.next;
        }

        ListNode revOdds = null;
        while (odds != null)
        {
            var tmp = odds.next;
            odds.next = revOdds;
            revOdds = odds;
            odds = tmp;
        }
        evens.next = revOdds;
        return head;
    }
}
