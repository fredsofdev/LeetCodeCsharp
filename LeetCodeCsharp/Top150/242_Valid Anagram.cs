using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Top150;
//Easy
internal class _242_Valid_Anagram
{
    //8 minutes
    public bool IsAnagram(string s, string t)
    {
        if(s.Length != t.Length) return false;

        Dictionary<char, int> sDis = new();
        foreach(char c in s)
        {
            if(sDis.ContainsKey(c)) sDis[c]++;
            else sDis[c] = 1;
        }

        foreach(char c in t)
        {
            if (!sDis.ContainsKey(c)) continue;
            if (sDis[c] > 1) sDis[c]--;
            else sDis.Remove(c);
        }
        return sDis.Count == 0;
    }
}
