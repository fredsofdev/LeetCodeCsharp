using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Week1
{
    internal class DepthQuickUnionUF: IUF
    {
        private readonly int[] id;

        public DepthQuickUnionUF(int N)
        {
            id = new int[N];
            for (int i = 0; i < N; i++) id[i] = i;
        }

        public bool connected(int p, int q) =>
            root(p) == root(q);

        public void union(int p, int q)
        {
            int pDepth = rootWithDepth(ref p);
            int qDepth = rootWithDepth(ref q);
            Console.WriteLine($"P_Depth:{pDepth} Q_Depth:{qDepth}");
            if (pDepth > qDepth) id[q] = p;
            else id[p] = q;
        }

        private int root(int child)
        {
            while (child != id[child]) child = id[child];
            return child;
        }

        private int rootWithDepth(ref int child)
        {
            int depth = 0;
            while(child != id[child])
            {
                child = id[child];
                depth++;
            }
            return depth;
        }
    }
}
