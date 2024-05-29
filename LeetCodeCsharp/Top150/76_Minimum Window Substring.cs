using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Top150;
//Hard
internal class _76_Minimum_Window_Substring
{
    //Failed, solved after seeing solution
    public string MinWindow(string s, string t)
    {
        Dictionary<char, int> chars = new();
        foreach (char c in t)
        {
            if (chars.ContainsKey(c)) chars[c]++;
            else chars[c] = 1;
        }

        int l = 0, r = 0, start = 0, lenMin = int.MaxValue;
        int count = t.Length;
        while (r < s.Length)
        {
            if (!chars.ContainsKey(s[r])) r++;
            else if (chars[s[r++]]-- > 0) count--;


            while (count == 0)
            {
                if (r - l < lenMin)
                {
                    start = l;
                    lenMin = r - l;
                }

                if (!chars.ContainsKey(s[l])) l++;
                else if (chars[s[l++]]++ == 0) count++;
            }
        }

        return lenMin == int.MaxValue ? "" : s.Substring(start, lenMin);
    }
}
