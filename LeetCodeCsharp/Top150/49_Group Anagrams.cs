using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Top150;
//Medium
internal class _49_Group_Anagrams
{
    //12 minutes
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        Dictionary<string, List<string>> dis = new();

        foreach (string str in strs)
        {
            char[] keyA = str.ToCharArray();
            Array.Sort(keyA);
            string key = new string(keyA);
            if(dis.ContainsKey(key)) dis[key].Add(str);
            else dis.Add(key, new List<string>() { str});
        }

        return dis.Values.ToArray();
    }
}
