using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Top150;
//Hard
internal class _68_TextJustification
{
    //51 minutes
    public IList<string> FullJustify(string[] words, int maxWidth)
    {
        List<string> result = new List<string>();   

        List<string> line = new List<string>();
        int wSize = 0;
        int p = 0;
        while (p < words.Length) 
        {
            if(wSize + line.Count + words[p].Length <= maxWidth)
            {
                wSize += words[p].Length;
                line.Add(words[p]);
                if(p++ != words.Length - 1) continue;
            }

            bool isLast = p == words.Length && line.Contains(words[p-1]);
            string strline = "";
            if (isLast || line.Count == 1) strline = string.Join(' ', line);
            else
            {
                int tSpace = maxWidth - wSize;
                int[] spaces = new int[line.Count -1];
                int s = 0;
                while (tSpace > 0)
                {
                    if(s == spaces.Length) s = 0;
                    spaces[s++]++;
                    tSpace--;
                }

                strline = line[0];
                for (int i = 1;i < line.Count;i++)
                {
                    strline += new string(' ', spaces[i-1]) + line[i];
                }
            }
            if (strline.Length < maxWidth) strline += new string(' ', maxWidth - strline.Length);
            result.Add(strline);
            wSize = 0;
            line.Clear();
        }
        return result;
    }

    public static void Run()
    {
        string[] words = new string[] { "This", "is", "an", "example", "of", "text", "justification." };
        int maxWidth = 16;
        var Just = new _68_TextJustification();
        var lines =  Just.FullJustify(words, maxWidth);
        foreach(string line in lines) Console.WriteLine(line);
    }
}
