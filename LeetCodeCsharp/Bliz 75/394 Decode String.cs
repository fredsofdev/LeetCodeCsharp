using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Bliz_75;
//Medium
internal class _394_Decode_String
{
    //20 minutes, solved after getting some hint
    public string DecodeString(string s)
    {
        Stack<string> stack = new();

        foreach(char c in s)
        {
            if(c != ']')
            {
                stack.Push(c.ToString());
            }

            int times = 1;
            if(intStack.Count > 0) times = intStack.Pop();

            string decode = enStack.Pop();
            while (times > 0) decode += decode;
            if (enStack.Count == 0) result += decode;
            else
            {
                StringBuilder str = new();
                while(stack.Peek() != "[")
                {
                    str.Insert(0, stack.Pop());
                }
                if(stack.Peek() == "[") stack.Pop();
                Console.Write(str.ToString());
                StringBuilder numStr = new();
                while (stack.TryPeek(out string n) && char.IsDigit(n[0]))
                {
                    numStr.Insert(0, stack.Pop());
                }

                int k = int.Parse(numStr.ToString());
                string temp = str.ToString();
                while(--k > 0) str.Append(temp);
                stack.Push(str.ToString());
            }
        }

        StringBuilder result = new();
        while(stack.Count > 0)
        {
            result.Insert(0, stack.Pop());
        }
        return result.ToString();
    }

    //Failed to solve
    public string DecodeString2(string s)
    {
        Stack<int> st = new();
        Stack<StringBuilder> st1 = new();
        StringBuilder sb = new StringBuilder();
        int n = 0;

        foreach (char c in s)
        {
            if (char.IsDigit(c))
            {
                n = n * 10 + (c - '0');
            }
            else if (c == '[')
            {
                st.Push(n);
                n = 0;
                st1.Push(sb);
                sb = new StringBuilder();
            }
            else if (c == ']')
            {
                int k = st.Pop();
                StringBuilder temp = sb;
                sb = st1.Pop();
                while (k-- > 0)
                {
                    sb.Append(temp);
                }
            }
            else
            {
                sb.Append(c);
            }
        }

        return sb.ToString();
    }
}
