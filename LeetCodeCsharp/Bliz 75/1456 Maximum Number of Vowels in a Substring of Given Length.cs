using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Bliz_75;
//Medium
internal class _1456_Maximum_Number_of_Vowels_in_a_Substring_of_Given_Length
{
    //7 minutes
    public int MaxVowels(string s, int k)
    {
        HashSet<char> vowels = new() { 'a', 'e', 'i', 'o', 'u' };

        int count = 0, max = 0;
        for(int i = 0;i < s.Length;i++)
        {
            if (vowels.Contains(s[i])) count++;
            if (i - k >= 0 && vowels.Contains(s[i - k])) count--;
            if (i >= k - 1) max = Math.Max(max, count);
        }
        return max;
    }
}
