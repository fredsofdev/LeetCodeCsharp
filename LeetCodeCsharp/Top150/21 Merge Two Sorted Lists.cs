using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Top150;
//Easy
internal class _21_Merge_Two_Sorted_Lists
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
    //19 minutes
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        ListNode pointer = new ListNode();
        ListNode head = pointer;
        while(list1 != null || list2 != null)
        {
            int val1 = list1 == null ? int.MaxValue : list1.val;
            int val2 = list2 == null ? int.MaxValue : list2.val;
            if (val1 > val2) list2 = list2.next;
            else list1 = list1.next;

            var newNode = new ListNode(Math.Min(val1,val2));
            pointer.next = newNode;
            pointer = newNode;
        }
        return head.next;
    }

    // Without creating new ListNode
    public ListNode MergeTwoLists2(ListNode list1, ListNode list2)
    {
        ListNode pointer = new ListNode();
        ListNode head = pointer;
        while (list1 != null && list2 != null)
        {
            if (list1?.val > list2?.val)
            {
                pointer.next = list2;
                list2 = list2.next;
            }
            else
            {
                pointer.next = list1;
                list1 = list1.next;
            }
            Console.WriteLine(pointer.val);
            pointer = pointer.next;
        }

        if (list1 == null) pointer.next = list2;
        else pointer.next = list1;

        return head.next;
    }
}
