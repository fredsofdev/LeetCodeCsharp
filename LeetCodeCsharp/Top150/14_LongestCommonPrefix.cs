using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Top150;
//Easy
internal class _14_LongestCommonPrefix
{
    //13 minutes
    public string LongestCommonPrefix(string[] strs)
    {
        string prefix = "";

        Array.Sort(strs);

        foreach (char c in strs[0])
        {
            prefix += c;
            foreach(string str in strs) 
                if(!str.StartsWith(prefix)) 
                    return prefix.Substring(0, prefix.Length - 1);
        }
        return prefix;
    }
}
