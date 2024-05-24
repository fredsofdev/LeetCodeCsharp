using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Top150;
//Easy
internal class _392_IsSubsequence
{
    //12 minutes
    public bool IsSubsequence(string s, string t)
    {
        if (s == "") return true;
        int sp = 0, tp = 0;

        while (tp < t.Length)
        {
            if (s[sp] == t[tp])
            {
                if (sp == s.Length - 1) return true;
                sp++;
                tp++;
            }
            else tp++;
        }

        return false;
    }
}
