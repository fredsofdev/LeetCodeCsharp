using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Week1.Assignment
{
    internal class Percolation : IPercolation
    {
        private IUF waitedUF;
        private int N;
        private int numberOfOsites;

        private bool[,] sites;
        public Percolation(int n)
        {
            N = n;
            numberOfOsites = 0;
            waitedUF = new WQUwithPathCompressionUF(n * n);
            sites = new bool[n,n];

            for(int i = 1; i < n; i++)
            {
                waitedUF.union(i-1,i);
                waitedUF.union(value(N-1,i-1), value(N - 1, i));
            }
        }

        private int value(int row, int col)
            => row * N + col;

        private bool valid(int row, int col)
        {
            if (row >= N || row < 0) return false;
            if (col >= N || col < 0) return false;
            return true;
        }

        public bool isFull(int row, int col)
        {
            if (!valid(row, col)) throw new ArgumentOutOfRangeException(); 
            return !sites[row,col];
        }

        public bool isOpen(int row, int col)
        {
            if (!valid(row, col)) throw new ArgumentOutOfRangeException();
            return sites[row, col];
        }

        public int numberOfOpenSites() => numberOfOsites;
        

        public void open(int row, int col)
        {
            if (!valid(row, col)) throw new ArgumentOutOfRangeException();
            if (sites[row, col]) return;
            
            sites[row, col] = true;
            numberOfOsites++;

            if (valid(row, col - 1) && sites[row, col - 1]) //Left
                waitedUF.union(value(row,col - 1), value(row , col));
            if (valid(row - 1, col) && sites[row - 1, col]) //Top
                waitedUF.union(value(row - 1, col), value(row, col));
            if (valid(row, col + 1) && sites[row, col + 1]) //Right
                waitedUF.union(value(row, col + 1), value(row, col));
            if (valid(row + 1, col) && sites[row + 1, col]) //Bottom
                waitedUF.union(value(row + 1, col), value(row, col));

        }

        public bool percolates() => waitedUF.connected(0, N*N-1);
        
    }
}
