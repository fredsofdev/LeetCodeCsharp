using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Bliz_75;
//Easy
//12 minutes
public class RecentCounter
{
    Queue<int> calls;
    public RecentCounter()
    {
        calls = new Queue<int>();
    }

    public int Ping(int t)
    {
        calls.Enqueue(t);
        while(calls.Peek() < t-3000) calls.Dequeue();
        return calls.Count;
    }
}
