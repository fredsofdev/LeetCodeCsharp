using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Bliz_75;
//Easy
internal class _1732_Find_the_Highest_Altitude
{
    //2 minutes
    public int LargestAltitude(int[] gain)
    {
        int alti = 0, max = 0;
        foreach(int g in gain)
        {
            alti += g;
            max = Math.Max(max, alti);
        }
        return max;
    }

}
