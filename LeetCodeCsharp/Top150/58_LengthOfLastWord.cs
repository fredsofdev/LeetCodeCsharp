using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Top150;
//Easy
internal class _58_LengthOfLastWord
{
    // 4 minutes
    public int LengthOfLastWord(string s)
    {
        s = s.Trim();
        s = s.Split(" ").Last();
        s = s.Trim();
        return s.Length;
    }
}
