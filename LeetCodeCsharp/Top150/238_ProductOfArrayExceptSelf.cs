using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Top150;
//Medium
internal class _238_ProductOfArrayExceptSelf
{
    //10 minutes after i have seen the solution
    public int[] ProductExceptSelf(int[] nums)
    {
        int[] answ = new int[nums.Length];
        int prefix = 1;
        for(int i = 0; i < nums.Length; i++)
        {
            answ[i] = prefix;
            prefix *= nums[i];
        }
        int serfix = 1;
        for(int i = nums.Length - 1; i >= 0; i--)
        {
            answ[i] *= serfix;
            serfix *= nums[i];
        }
        return answ;
    }
}
