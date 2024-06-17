using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Bliz_75;
//Easy
internal class _2215_Find_the_Differance_of_Two_Arrays
{
    //8 minutes
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
    {
        List<int>[] result = new List<int>[] { new(),new() };
        HashSet<int> num2Set = nums2.ToHashSet();
        HashSet<int> num1Set = nums1.ToHashSet();
        foreach (int i in num1Set)
        {
            if(!num2Set.Contains(i)) result[0].Add(i);
        }
        foreach(int i in num2Set)
        {
            if (!num1Set.Contains(i)) result[1].Add(i);
        }
        return result;
    }
    //Optimal
    public IList<IList<int>> FindDifference2(int[] nums1, int[] nums2)
    {
        List<int>[] result = new List<int>[] { new(), new() };
        HashSet<int> num2Set = nums2.ToHashSet();
        HashSet<int> num1Set = nums1.ToHashSet();
        foreach (int i in num1Set)
        {
            if (num2Set.Contains(i))
            {
                num1Set.Remove(i);
                num2Set.Remove(i);
            }
        }
        result[0] = num1Set.ToList();
        result[1] = num2Set.ToList();
      
        return result;
    }
}
