using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Week1.Week1Quiz;

internal class UFwithCanonicalE
{
    public readonly int[] id;
    private readonly int[] sz;
    private readonly int[] lg;

    public UFwithCanonicalE(int N)
    {
        id = new int[N];
        sz = new int[N];
        lg = new int[N];
        for (int i = 0; i < N; i++)
        {
            id[i] = i;
            sz[i] = 1;
            lg[i] = 0;
        }
    }

    public bool connected(int p, int q) =>
        root(p) == root(q);

    public void union(int p, int q)
    {
        int i = root(p);
        int j = root(q);
        if (i == j) return;
        if (sz[i] > sz[j])
        {
            id[j] = i;
            sz[i] += sz[j];
            lg[i] = Math.Max(p, Math.Max(q, lg[i]));

        }
        else
        {
            id[i] = j;
            sz[j] += sz[i];
            lg[j] = Math.Max(p, Math.Max(q, lg[j]));
        }


        Console.WriteLine();
        for (int g = 0; g < sz.Length; g++)
        {
            if (sz[g] == 0) continue;
            Console.Write($" [{g},{sz[g]}] ");
        }
        Console.WriteLine();
    }

    public int find(int i)
    {
        int iroot = root(i);
        return lg[iroot];
    }

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
