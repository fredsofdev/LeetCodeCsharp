using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Top150;
//Easy
internal class _127_ValidPalindrome
{
    //12 minutes
    public bool IsPalindrome(string s)
    {
        s = s.ToLower();
        s = string.Concat(s.Where(char.IsLetterOrDigit));
        string rev = string.Join("", s.Reverse());
        return s == rev;
    }

    //5 minutes for 2 pointer implementation
    public bool IsPalindrome2(string s)
    {
        s = s.ToLower();
        s = string.Concat(s.Where(char.IsLetterOrDigit));

        int l = 0, h = s.Length - 1;
        while (l < h)
        {
            if (s[l++] != s[h--]) return false; 
        }

        return true;
    }
}
