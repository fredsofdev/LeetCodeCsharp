using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Bliz_75;
//Medium
internal class _2130_Maximum_Twin_Sum_of_a_Linked_List
{
    //10 minutes
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
    public int PairSum(ListNode head)
    {
        int max = int.MinValue;
        Stack<int> half = new Stack<int>();
        ListNode fast = head;
        var slow = head;
        while (fast != null)
        {
            half.Push(slow.val);
            slow = slow.next;
            fast = fast.next.next;
        }

        while(slow != null)
        {
            max = Math.Max(max, slow.val + half.Pop());
            slow = slow.next;
        }
        return max;
    }
}
