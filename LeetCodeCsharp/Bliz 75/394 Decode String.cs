using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Bliz_75;

internal class _394_Decode_String
{
    public string DecodeString(string s)
    {
        Stack<string> enStack = new();
        Stack<int> intStack = new();
        string result = "";
        int i = 0;
        while(i < s.Length)
        {
            string num = "";
            while (i < s.Length && char.IsDigit(s[i])) num+=s[i++];
            if (int.TryParse(num, out int k)) intStack.Push(k);

            string encode = "";
            while (i < s.Length && char.IsLetter(s[i])) encode += s[i++];
            if(encode != "") enStack.Push(encode);

            if (s[i] == '[' && i != s.Length-1)
            {
                i++;
                continue;
            }

            int times = 1;
            if(intStack.Count > 0) times = intStack.Pop();

            string decode = enStack.Pop();
            while (times > 0) decode += decode;
            if (enStack.Count == 0) result += decode;
            else
            {
                decode = enStack.Pop() + decode;
                enStack.Push(decode);
            }
            i++;
        }

        return enStack.Pop();
    }
}


//Two Stacks for ecoded_string and k interger.

//Iterate through input string by each chars.

//Through the iteration I push ints and chars to stacks respectively.

//then i will start to pop them when I have closing bracket chars.

