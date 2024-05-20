using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Top150;

//Easy
internal class _88_MergeSortedArray
{
    //took 55 minutes because i did not read decs properly
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        if (nums2.Length == 0) return;

        int[] tmp = new int[nums1.Length];
        for(int i = 0; i < nums1.Length; i++)
        {
            tmp[i] = nums1[i];  
        }

        int j = 0, k = 0;
        for(int i = 0;i < m+n; i++)
        {
            int cmp = tmp[j].CompareTo(nums2[k]);
            if(cmp <= 0 && tmp[j] != 0) nums1[i] = tmp[j++];
            else nums1[i] = nums2[k++];
        }
    }

    //got a hint from solutions but this is slower
    public void Merge2(int[] nums1, int m, int[] nums2, int n)
    {
        for(int i = m; i < m+n; i++)
        {
            nums1[i] = nums2[i-m];
        }

        Array.Sort(nums1);
    }
}
