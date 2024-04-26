using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Week1.Week1Quiz
{
    internal class ThreeSum
    {
        public List<List<int>> FindTarget(int[] array, int target)
        {
            if(array.Length < 3) return new List<List<int>>();
            List<List<int>> result = new();

            Array.Sort(array);

            for (int i = 0; i < array.Length - 2; i++)
            {
                int left = i + 1;
                int right = array.Length - 1;

                while(left < right)
                {
                    int sum = array[i] + array[left] + array[right];

                    if(sum == target)
                    {
                        result.Add(new List<int>() { array[i], array[left], array[right] });

                        while(left < right && array[left] == array[left + 1]) left++;
                        while(left < right && array[right] == array[right - 1]) right--;
                        left++;
                        right--;
                    }
                    else if(sum < target)
                    {
                        left++;
                    }
                    else right--;
                }
            }
            return result;
        }
    }
}
