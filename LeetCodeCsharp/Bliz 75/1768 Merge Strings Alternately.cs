using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Bliz_75;
//Easy
internal class _1768_Merge_Strings_Alternately
{
    //6 minutes
    public string MergeAlternately(string word1, string word2)
    {
        char[] result = new char[word1.Length+word2.Length];
        int i= 0, j= 0;
        while(i < word1.Length || j < word2.Length)
        {
            if(i < word1.Length)
            {
                result[i+j] = word1[i];
                i++;
            }
            if(j < word2.Length)
            {
                result[i+j] =  word2[j];
                j++;
            }
        }
        return new string(result);
    }
}
