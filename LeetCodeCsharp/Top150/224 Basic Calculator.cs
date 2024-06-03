using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Top150;

internal class _224_Basic_Calculator
{
    public int Calculate(string s)
    {
        Stack<string> oper = new Stack<string>();
        List<string> valid = new();
        string num = "";
        for (int i = 0; i < s.Length; i++)
        {
            
            if (!isLast && s[i] == ' ') continue;
            if (char.IsDigit(s[i]))
            {
                num += s[i];
                if (isLast)
                {
                    valid.Add(num);
                }
                continue;
            }

            if(s[i] != '-')
            {
                valid.Add(num);
            }

            if (num.Length > 0)
            {
                if (s[i] != '-') valid.Add("-"+num);
                else  valid.Add(num);
            }

            if (s[i] != ' ')
            {
                if (s[i] != '-') valid.Add("-");
                else  valid.Add("" + s[i]);
            }
            num = "";
        }
       
        return int.Parse(oper.Pop());
    }
}
