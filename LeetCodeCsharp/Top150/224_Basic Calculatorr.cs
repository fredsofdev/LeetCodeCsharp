using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Top150;

internal class _224_Basic_Calculatorr
{
    public int Calculate(string s)
    {
        s  = s.Trim(' ');
        Stack<string> stack = new();
        Stack<char> oper = new();
        int i = 0;
        while(i < s.Length)
        {
            if (s[i] == ' ')
            {
                i++;
                continue;
            }
            if (char.IsDigit(s[i]))
            {
                string num = "";
                int dId = i;
                while (dId < s.Length && char.IsDigit(s[dId])) num += s[dId++];
                if(stack.TryPeek(out string n) && int.TryParse(n,out int v1))
                {
                    int v2 = int.Parse(num);
                    char op = oper.Pop();
                    int res = 0;
                    if (op == '+') res = v1 + v2;
                    else if (op == '-') res = v1 - v2;
                    else if (op == '*') res = v1 * v2;
                    else res = v1 / v2;
                    stack.Push(res.ToString());
                }
                else stack.Push(num);
                i = dId;
            }
            else if (s[i] != ')' && s[i] != '(') oper.Push(s[i]);
            else if (s[i] == '(') stack.Push("" + s[i]);
            else
            {
                string hold = stack.Pop();
                stack.Pop();
                stack.Push(hold);
            }
            i++;       
        }

        while(oper.Count > 0)
        {
            int v2 = int.Parse(stack.Pop());
            int v1 = int.Parse(stack.Pop());
            char op = oper.Pop();
            int res = 0;
            if (op == '+') res = v1 + v2;
            else if (op == '-') res = v1 - v2;
            else if (op == '*') res = v1 * v2;
            else res = v1 / v2;
            stack.Push(res.ToString());
        }

        return int.Parse(stack.Pop());
        
    }

    public int Calculate2(string s)
    {
        s = s.Trim(' ');
        List<string> cal = new List<string>();
        bool sign = false;
        int i = 0;
        while (i < s.Length)
        {
            if (s[i] == ' ')
            {
                i++;
                continue;
            }
            string num = sign? "-": "";
            if (char.IsDigit(s[i]))
            {
                int dId = i;
                while (dId < s.Length && char.IsDigit(s[dId])) num += s[dId++];
                cal.Add(num);
                i = dId;
                sign = false;
            }
            else if (s[i] == '-' && cal.Last() == "(")
            {
                sign = true;
            }
            else cal.Add("" + s[i]);
            i++;
        }
        Console.WriteLine(string.Join(",", cal));
        return 0;
    }

}
