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
        if(nums.Length < 3) return false;
        int first = int.MaxValue, second = int.MinValue;
        foreach (int num in nums)
        {
            if (num <= first) first = num;
            else if (num <= second) second = num;
            else return true;
        }
        return false;
    }
}
