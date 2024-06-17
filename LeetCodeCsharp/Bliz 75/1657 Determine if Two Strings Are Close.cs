using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Bliz_75;
//Medium
internal class _1657_Determine_if_Two_Strings_Are_Close
{
    //15 minutes
    public bool CloseStrings(string word1, string word2)
    {
        if(word1.Length != word2.Length) return false;
        Dictionary<char, int> count1 = new();
        foreach (char chr in word1)
        {
            if(!count1.TryAdd(chr, 1)) count1[chr]++;
        }
        Dictionary<char, int> count2 = new();
        foreach (char chr in word2)
        {
            if (!count2.TryAdd(chr, 1)) count2[chr]++;
        }
        List<int> w1Count = count1.Values.ToList();
        foreach(var pair in count2)
        {
            if(!count1.ContainsKey(pair.Key)) return false;
            if(!w1Count.Remove(pair.Value)) return false;
        }
        return true;
    }
}
