using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Top150;

//Easy
internal class _26_RemoveDuplicatesFromSortedArray
{
    // 8:46 minutes
    public int RemoveDuplicates(int[] nums)
    {
        int k = 1, p = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            if (nums[p] < nums[i])
            {
                k++;
                nums[++p] = nums[i];
            }
        }
        return k;
    }
}