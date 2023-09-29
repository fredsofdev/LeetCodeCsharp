using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Arrays
{
    internal class Next_Creater_Element
    {
        public int[] NextGreaterElement(int[] nums1, int[] nums2)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < nums1.Length; i++)
            {
                int targetIndex = Array.IndexOf(nums2, nums1[i]);
                if (targetIndex == nums2.Length - 1)
                {
                    result.Add(-1);
                    continue;
                }
                for (int j = targetIndex+1; j < nums2.Length; j++)
                {
                    if (nums2[j] > nums1[i])
                    {
                        result.Add(nums2[j]);
                        break;
                    }
                    else if(j == nums2.Length - 1) 
                        result.Add(-1);
                }
            }

            return result.ToArray();
        }

        public int[] NextGreaterElement2(int[] nums1, int[] nums2)
        {
            int[] result = new int[nums1.Length];
            for (int i = 0; i < nums1.Length; i++)
            {
                int targetIndex = Array.IndexOf(nums2, nums1[i]);
                if (targetIndex == nums2.Length - 1)
                {
                    result[i] = -1;
                    continue;
                }
                for (int j = targetIndex + 1; j < nums2.Length; j++)
                {
                    if (nums2[j] > nums1[i])
                    {
                        result[i] = nums2[j];
                        break;
                    }
                    else if (j == nums2.Length - 1)
                        result[i] = -1;
                }
            }

            return result.ToArray();
        }
    }
}
