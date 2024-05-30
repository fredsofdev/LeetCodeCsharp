using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Top150;
//Easy
internal class _205_Isomerphic_Strings
{
    //35 minutes. How no Idea at first
    public bool IsIsomorphic(string s, string t)
    {
        HashSet<char> sSet = s.ToHashSet();
        Dictionary<char, int> sDis = new();
        int pos = 0;
        foreach(char c in sSet) sDis[c] = pos++;

        HashSet<char> tSet = t.ToHashSet();
        Dictionary<char, int> tDis = new();
        int tpos = 0;
        foreach (char c in tSet) sDis[c] = tpos++;

        for(int i = 0; i < s.Length; i++)
        {
            if (sDis[s[i]] != tDis[t[i]]) return false;
        }
        return true;
    }


    public bool IsIsomorphic2(string s, string t)
    {
        Dictionary<char, int> sDis = new();
        for(int i= 0; i < s.Length; i++)
        {
            if (!sDis.ContainsKey(s[i])) sDis[s[i]] = i;
        }

        Dictionary<char, int> tDis = new();
        for(int i = 0;i < t.Length; i++)
        {
            if (!tDis.ContainsKey(t[i])) tDis[t[i]] = i;
            if (sDis[s[i]] != tDis[t[i]]) return false;
        }
        return true;
    }
}
