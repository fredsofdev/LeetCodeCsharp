using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Bliz_75;
//Easy
internal class _1071_Greatest_Common_Divisor_of_Strings
{
    //29 minutes
    public string GcdOfStrings(string str1, string str2)
    {
        Console.WriteLine(str1 + " " + str2);
        if (str2 == "" || str1 == str2) return str1;
        if (str1.Length >= str2.Length && !str1.StartsWith(str2)) return "";

        string sub = str1;
        while (sub.StartsWith(str2)) sub = sub.Substring(str2.Length);
        return GcdOfStrings(str2, sub);
    }
}
