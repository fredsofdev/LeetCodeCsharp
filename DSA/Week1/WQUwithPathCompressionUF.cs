using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Week1
{
    internal class WQUwithPathCompressionUF : WeightedQuickUnionUF
    {
        public WQUwithPathCompressionUF(int N) : base(N)
        {}

        public override int root(int child)
        {
            while (child != id[child])
            {
                id[child] = id[id[child]];//Added for path compression
                child = id[child];
            }
            return child;
        }
    }
}
