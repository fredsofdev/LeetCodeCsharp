using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Top150;
//Easy
internal class _290_Word_Pattern
{
    //10 minutes
    public bool WordPattern(string pattern, string s)
    {
        Dictionary<char, int> pDis = new();
        for (int i = 0; i < pattern.Length; i++) 
            if (!pDis.ContainsKey(pattern[i])) pDis[pattern[i]] = i;

        string[] sList = s.Split(" ");
        if (sList.Length != pattern.Length) return false;
        Dictionary<string, int> sDis = new();
        for(int i = 0;i < sList.Length; i++)
        {
            if (!sDis.ContainsKey(sList[i])) sDis[sList[i]] = i;
            if (sDis[sList[i]] != pDis[pattern[i]]) return false;
        }
        return true;
    }

    public bool WordPattern2(string pattern, string s)
    {
        string[] sList = s.Split(" ");
        if (sList.Length != pattern.Length) return false;
        Dictionary<string, int> sDis = new();
        for (int i = 0; i < sList.Length; i++)
        {
            if (!sDis.ContainsKey(sList[i])) sDis[sList[i]] = i;
        }
        Dictionary<char, int> pDis = new();
        for (int i = 0; i < pattern.Length; i++)
        {
            if (!pDis.ContainsKey(pattern[i])) pDis[pattern[i]] = i;
            if (sDis[sList[i]] != pDis[pattern[i]]) return false;
        }

        return true;
    }
}
