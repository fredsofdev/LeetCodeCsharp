using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Week1.Week1Quiz;

internal class SocialNetworkC
{
    public readonly int[] id;
    private readonly int[] sz;
    private long alluserConnectedTime; 

    public SocialNetworkC(int N)
    {
        id = new int[N];
        sz = new int[N];
        for (int i = 0; i < N; i++)
        {
            id[i] = i;
            sz[i] = 1;
        }
        alluserConnectedTime = 0;
    }

    public bool connected(int p, int q) =>
        root(p) == root(q);

    public void FormFriendship(int p, int q, long timestamp)
    {
        int i = root(p);
        int j = root(q);
        if (i == j) return;
        if (sz[i] > sz[j])
        {
            id[j] = i;
            sz[i] += sz[j];
            sz[j] = 0;
        }
        else
        {
            id[i] = j;
            sz[j] += sz[i];
            sz[i] = 0;
        }
        alluserConnectedTime = timestamp;
        Console.WriteLine();
        for (int g = 0; g < sz.Length; g++)
        {
            if (sz[g] == 0) continue;
            Console.Write($" [{g},{sz[g]}] ");
        }
        Console.WriteLine();
    }

    public long GetEarliestTime() => alluserConnectedTime;

    public virtual int root(int child)
    {
        while (child != id[child])
        {
            id[child] = id[id[child]];
            child = id[child];
        }
        return child;
    }
}
