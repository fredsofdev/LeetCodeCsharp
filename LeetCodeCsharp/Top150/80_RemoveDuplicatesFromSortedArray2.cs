using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Top150;

//Medium
internal class _80_RemoveDuplicatesFromSortedArray2
{
    
    //17 minuts 
    public int RemoveDuplicates(int[] nums)
    {
        int k = 1, p = 0, count = 0;
        if (nums.Length == 1) return k;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[p] < nums[i])
            {
                count = 0;
                k++;
                nums[++p] = nums[i];
            }
            else if (count < 1)
            {
                count++;
                k++;
                nums[++p] = nums[i];
            }
        }
        return k;
    }
}
