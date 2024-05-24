using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Top150;
//Medium
internal class _167_TwoSum2_InputArray_IsSorted
{
    //16 minutes
    public int[] TwoSum(int[] numbers, int target)
    {
        int p = numbers.Length - 1;
        while (p > 0)
        {
            int next = target - numbers[p];
            int nextInd = Array.IndexOf(numbers, next, 0, p);
            if (nextInd != -1) return new int[] { nextInd + 1, p + 1 };
            p--;
        }
        return new int[] { 0, 0 };
    }
    //3 minutes to implement two pointer solution
    public int[] TwoSum2(int[] numbers, int target)
    {
        int l = 0, h = numbers.Length-1;
        while (l < h)
        {
            int sum = numbers[l] + numbers[h];
            if(sum == target) return new int[] { l, h };
            else if(sum > target) h--;
            else l++;
        }
        return new int[] { 0, 0 };
    }

}
