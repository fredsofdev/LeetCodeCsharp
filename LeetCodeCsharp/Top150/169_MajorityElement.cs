using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Top150;
//Easy
internal class _169_MajorityElement
{
    //16 minuts because cannot find the correnct syntax for sorting Dictionary.
    public int MajorityElement(int[] nums)
    {
        Dictionary<int, int> pairs = new Dictionary<int, int>();
        foreach (int i in nums)
        {
            if(pairs.ContainsKey(i)) pairs[i] = pairs[i] + 1;
            else pairs[i] = 1;
        }

        return pairs.OrderBy(x => x.Value).Last().Key;
    }

    // Optimized version
    //5 minuts 
    public int MajorityElement2(int[] nums)
    {
        int current = nums[0];
        int count = 1;

        for(int i=1; i< nums.Length; i++)
        {
            if(current == nums[i]) count++;
            else if(count == 0)
            {
                current = nums[i];
                count = 1;
            }
            else
            {
                count--;
            }
        }
        return current;
        
    }
}
