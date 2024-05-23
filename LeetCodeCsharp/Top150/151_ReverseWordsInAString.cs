using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Top150;

//Medium
internal class _151_ReverseWordsInAString
{
    //7 minutes
    public string ReverseWords(string s)
    {
        s = s.Trim();
        string[] words = s.Split(' ');
        string word = "";
        for(int i = words.Length - 1; i >= 0; i--)
        {
            if(words[i] != "") word += " " + words[i];
        }
        return word.TrimStart();
    }
}
