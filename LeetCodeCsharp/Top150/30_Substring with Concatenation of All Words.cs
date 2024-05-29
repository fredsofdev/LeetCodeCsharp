using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Top150;
//Hard
internal class _30_Substring_with_Concatenation_of_All_Words
{
    public IList<int> FindSubstring(string s, string[] words)
    {
        int wordSize = words[0].Length;
        if (wordSize * words.Length > s.Length) return new List<int>();
        Dictionary<string, int> map = new Dictionary<string, int>();
        foreach (string word in words)
        {
            if (map.ContainsKey(word)) map[word]++;
            else map[word] = 1;
        }
        List<int> result = new();
        for(int i = 0; i <= s.Length - (words.Length * wordSize); i++)
        {
            Dictionary<string, int> set = new(map);
            for (int j = 0; j < words.Length; j++)
            {
                string word = s.Substring(i + (j * wordSize), wordSize);
                if (set.ContainsKey(word) && words.Contains(word))
                {
                    if (set[word] == 1) set.Remove(word);
                    else set[word]--;
                }
                else break;
            }
            if (set.Count == 0) result.Add(i);
        }
        return result;
    }

}
