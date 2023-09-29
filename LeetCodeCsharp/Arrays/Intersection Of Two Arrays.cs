using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Arrays
{
    internal class Intersection_Of_Two_Arrays
    {
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            HashSet<int> resultSet = new();

            for(int i = 0; i < nums1.Length; i++)
            {
                if (nums2.Contains(nums1[i])) resultSet.Add(nums1[i]);
            }
            return resultSet.ToArray();
        }

        public int[] Intersect(int[] nums1, int[] nums2)
        {
            HashSet<int> resultSet1 = new();
            HashSet<int> resultSet2 = new();

            for (int i = 0; i < nums1.Length; i++)
            {
                for(int j = 0; j < nums2.Length; j++)
                {
                    if(nums1[i] == nums2[j] && !resultSet1.Contains(i) && !resultSet2.Contains(j))
                    {
                        resultSet1.Add(i);
                        resultSet2.Add(j);
                    } 
                }
            }
            
            List<int> result = new List<int>();
            foreach(int i in resultSet1)
            {
                result.Add(nums1[i]);
            }

            return result.ToArray();
        }
    }
}
