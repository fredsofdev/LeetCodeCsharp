using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Bliz_75;
//Easy
internal class _345_Reverse_Vowels_of_a_Strign
{
    //20 minutes 
    public string ReverseVowels(string s)
    {
        HashSet<char> vowals = new() { 'a', 'e', 'i', 'o', 'u' };
        int l = 0, r = s.Length -1;
        char[] chars = s.ToCharArray(); 
        while (l < r)
        {
            while (!vowals.Contains(char.ToLower(chars[l]))) l++;
            while (!vowals.Contains(char.ToLower(chars[r]))) r--;

            var temp = chars[l];
            chars[l] = chars[r];
            chars[r] = temp;
            l++;
            r--;
        }
        return new string(chars);
    }
}
