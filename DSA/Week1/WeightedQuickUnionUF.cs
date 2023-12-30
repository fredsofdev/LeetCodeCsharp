using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Week1
{
    internal class WeightedQuickUnionUF: IUF
    {
        public readonly int[] id;
        private readonly int[] sz;

        public WeightedQuickUnionUF(int N)
        {
            id = new int[N];
            sz = new int[N];
            for (int i = 0; i < N; i++)
            {
                id[i] = i;
                sz[i] = 1;
            }
        }

        public bool connected(int p, int q) =>
            root(p) == root(q);

        public void union(int p, int q)
        {
            int i = root(p);
            int j = root(q);
            if (sz[i] > sz[j]) { 
                id[j] = i; 
                sz[i] += sz[j];
                sz[j] = 0;
            }
            else { 
                id[i] = j; 
                sz[j] += sz[i];
                sz[i] = 0;
            }

            Console.WriteLine();
            for(int g = 0; g < sz.Length; g++)
            {
                if (sz[g] == 0) continue;
                Console.Write($" [{g},{sz[g]}] ");
            }
            Console.WriteLine();
        }

        public virtual int root(int child)
        {
            while (child != id[child]) child = id[child];
            return child;
        }
    }
}
