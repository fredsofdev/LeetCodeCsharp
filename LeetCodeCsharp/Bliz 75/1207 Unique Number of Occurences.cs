using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Bliz_75;
//Easy
internal class _1207_Unique_Number_of_Occurences
{
    //4 minutes
    public bool UniqueOccurrences(int[] arr)
    {
        Dictionary<int, int> count = new();
        foreach (int i in arr)
        {
            if(count.ContainsKey(i)) count[i] += 1;
            else count[i] = 1;
        }
        HashSet<int> rep = new();

        foreach (int i in count.Values)
        {
            if(!rep.Add(i)) return false;
        }
        return true;
    }
}
