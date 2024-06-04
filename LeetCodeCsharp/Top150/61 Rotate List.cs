using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Top150;
//Medium
internal class _61_Rotate_List
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
    //55 minutes, because i thought array rotation solution (reversing 3 times) work for linked list too,
    //it was hard to implement
    public ListNode RotateRight(ListNode head, int k)
    {
        if (k == 0 || head == null) return head;
        var curr = head;
        int count = 1;
        while (curr.next != null)
        {
            curr = curr.next;
            count++;
        }
        Console.WriteLine(count - k);
        curr.next = head;
        int pos = count - (k % count);
        while (--pos > 0) head = head.next;

        var result = head.next;
        head.next = null;
        return result;
    }
}
