using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Arrays
{
    internal class Minimum_Index_Sum_of_Two_Lists
    {
        public string[] FindRestaurant(string[] list1, string[] list2)
        {
            Dictionary<string, int> temp = new();

            for (int i = 0; i < list1.Length; i++)
            {
                for (int j = 0; j < list2.Length; j++)
                {
                    if (list1[i] == list2[j])
                    {
                        temp[list1[i]] = i + j;
                    }
                }
            }
            int minSum = temp.Values.Min();

            var smallestPairs = temp.Where(x => x.Value == minSum).ToList();

            return smallestPairs.ConvertAll(x => x.Key).ToArray();
        }

        public string[] FindRestaurant2(string[] list1, string[] list2)
        {
            Dictionary<string, int> map = new Dictionary<string, int>();
            for (int i = 0; i < list1.Length; i++)
            {
                map.Add(list1[i], i);
            }

            List<string> commonStrings = new List<string>();
            int indexSum = Int32.MaxValue;
            for (int i = 0; i < list2.Length; i++)
            {

                if (map.ContainsKey(list2[i]))
                {
                    int curIndexSum = i + map[list2[i]];
                    if (curIndexSum < indexSum)
                    {
                        commonStrings.Clear();
                        commonStrings.Add(list2[i]);
                        indexSum = curIndexSum;
                    }
                    else if (curIndexSum == indexSum)
                    {
                        commonStrings.Add(list2[i]);
                    }
                }
            }

            return commonStrings.ToArray();
        }

    }
}
