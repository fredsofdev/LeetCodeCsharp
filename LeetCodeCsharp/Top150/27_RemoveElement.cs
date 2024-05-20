using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Top150;

//Easy
internal class _27_RemoveElement
{
    //3 minuts, this does not include reading decs and understanding
    public int RemoveElement(int[] nums, int val)
    {
        int count = 0;
        int p = 0;
        for(int i = 0;  i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                count++;
                nums[p++] = nums[i];
            }
        }
        return count;
    }
}
