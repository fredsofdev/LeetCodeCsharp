using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Bliz_75;

internal class _334_Increasing_Triplet_Subsequence
{
    public bool IncreasingTriplet(int[] nums)
    {
        Stack<int> stack = new Stack<int>();
        stack.Push(nums[0]);
        for(int i  = 0; i<nums.Length; i++)
        {
            if (stack.Peek() < nums[i])
            {
                stack.Push(nums[i]);
            }
            else
            {
                while (stack.TryPeek(out int val) && val >= nums[i]) stack.Pop();
                stack.Push(nums[i]);
            }
            if (stack.Count == 3) return true;
        }
        return false;
    }
}
