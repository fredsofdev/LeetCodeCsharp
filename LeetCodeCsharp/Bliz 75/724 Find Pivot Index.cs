using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Bliz_75;
//Easy 
internal class _724_Find_Pivot_Index
{
    //7 minutes
    public int PivotIndex(int[] nums)
    {
        int sum = nums.Sum();
        int lSum = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            if(sum - nums[i] - lSum == lSum) return i;
            lSum += nums[i];
        }
        return -1;
    }
}
