using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Top150;
//Easy
internal class _383__Ransom_Note
{
    //6 minutes
    public bool CanConstruct(string ransomNote, string magazine)
    {
        if(ransomNote.Length > magazine.Length) return false;
        Dictionary<char, int> count = new();
        foreach(char c in ransomNote)
        {
            if(count.ContainsKey(c)) count[c]++;
            else count[c] = 1;
        }
        foreach(char c in magazine)
        {
            if (!count.ContainsKey(c)) continue;
            else if (count[c] > 1) count[c]--;
            else count.Remove(c);
        }

        return count.Count == 0;
    }
}
