using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Top150;
//Easy
internal class _28_FindTheIndexOfTheFirstOccurrenceInAString
{
    //36 minutes
    public int StrStr(string haystack, string needle)
    {
        if (haystack.Length < needle.Length) return -1;
        for (int i = 0; i < haystack.Length; i++)
        {
            if (haystack[i] != needle[0]) continue;
            if (haystack.Substring(i, haystack.Length - i).StartsWith(needle)) return i;
        }
        return -1;
    }

    //optimation
    public int StrStr2(string haystack, string needle)
    {
        return haystack.IndexOf(needle);
    }
}
