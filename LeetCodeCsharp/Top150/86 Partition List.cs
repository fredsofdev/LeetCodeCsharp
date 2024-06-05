using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Top150;
//Medium
internal class _86_Partition_List
{
    //29 minutes
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

    public ListNode Partition(ListNode head, int x)
    {
        List<ListNode> lft = new();
        List<ListNode> rft = new();
        while (head != null)
        {
            if (head.val < x) lft.Add(head);
            else rft.Add(head);
            head = head.next;
        }
        lft.Reverse();
        rft.Reverse();
        ListNode newHead = null;
        foreach (var node in rft)
        {
            var tmp = node;
            tmp.next = newHead;
            newHead = tmp;
        }

        foreach (var node in lft)
        {
            var tmp = node;
            tmp.next = newHead;
            newHead = tmp;
        }
        return newHead;
    }
    //Using Two pointer solution;
    public ListNode Partition2(ListNode head, int x)
    {
        ListNode lftSentinel = new ();
        ListNode rtSentinel = new ();
        var lftEnd = lftSentinel;
        var rtEnd = rtSentinel;
         
        while(head != null)
        {
            var next = head.next;
            head.next = null;
            if(head.val < x)
            {
                lftEnd.next = head;
                lftEnd = lftEnd.next;
            }
            else
            {
                rtEnd.next = head;
                rtEnd = rtEnd.next;
            }
            head = next;
        }
        lftEnd.next = rtSentinel.next;

        return lftSentinel.next;
        
    }
}
