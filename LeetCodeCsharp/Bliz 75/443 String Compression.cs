using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Bliz_75;
//Medium 
internal class _443_String_Compression
{
    //Solved in 2 hours, problem is I keep trying to solve it with one loop where it is hard to implement
    public int Compress(char[] chars)
    {
        if (chars.Length == 1) return 1;
        char lastChar = chars[0];
        int count = 1;
        int last = 0, curr = 1;
        while (curr < chars.Length)
        {
            char ch = chars[curr];
            Console.WriteLine($"{last}  {curr}");
            if (lastChar == ch)
            {
                count++;
                if (curr < chars.Length - 1)
                {
                    curr++;
                    continue;
                }
            }

            chars[last++] = lastChar;
            Console.WriteLine($"{last} {count} {lastChar != ch}");
            if (count != 1)
            {
                string countS = count.ToString();
                for (int i = 0; i < countS.Length; i++) chars[last++] = countS[i];
                count = 1;
            }
            if (curr == chars.Length - 1 && lastChar != ch) chars[last++] = ch;
            lastChar = chars[curr++];
        }
        Array.Copy(chars, chars, last);
        return last;
    }

    //23 minutes  with two loop solution
    public int Compress2(char[] chars)
    {
        int curr = 0, result = 0;
        
        while(curr < chars.Length)
        {
            int groupCount = 1;

            while((curr + groupCount) < chars.Length -1 && 
                chars[curr + (groupCount - 1)] == chars[curr + groupCount]) groupCount++;
            Console.WriteLine($"{groupCount}  {curr}  {result}");
            if(result < chars.Length) chars[result++] = chars[curr];
            if(groupCount != 1)
            {
                var groupCountS = groupCount.ToString();
                foreach(char d in groupCountS) chars[result++] = d;
            }
            curr += groupCount;
        }

        return result;
    }

    public static void Run()
    {
        var prob = new _443_String_Compression();
        Console.WriteLine(prob.Compress2(new char[] {'a','a'}));
    }
}
