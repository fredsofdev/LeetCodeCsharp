using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Top150;
//Easy
internal class _228_Summary_Ranges
{
    //22 minutes
    public IList<string> SummaryRanges(int[] nums)
    {
        List<string> result = new List<string>();
        int l = 0, r = 0;
        while (l < nums.Length)
        {
            while (r != nums.Length - 1 && nums[r + 1] - nums[r] == 1) r++;
            string summ = l == r ? nums[l].ToString() : $"{nums[l]}->{nums[r]}";
            result.Add(summ);
            l = ++r;
        }
        return result;
    }
}
