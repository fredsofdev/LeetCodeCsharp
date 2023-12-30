using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Week1;

internal class QuickUnionUF : IUF
{
    private readonly int[] id;

    public QuickUnionUF(int N)
    {
        id = new int[N];
        for (int i = 0; i < N; i++) id[i] = i;
    }
    public bool connected(int p, int q) =>
        root(p) == root(q);
    

    public void union(int p, int q) =>
        id[root(p)] = root(q);

    private int root(int child)
    {
        while(child != id[child]) child = id[child];
        return child;
    }
}
