using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Bliz_75;
//Easy
internal class _1431_Kids_With_the_Greatest_Number_of_Candies
{
    //3 minutes
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        int max = 0;
        foreach(int count in candies) max = Math.Max(max, count);  

        List<bool> result = new List<bool>();
        foreach (var cand in candies)
        {
            if(cand + extraCandies >= max) result.Add(true);
            else result.Add(false);
        }
        return result;
    }
}
