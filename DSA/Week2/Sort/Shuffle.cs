using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Week2.Sort
{
    internal class Shuffle
    {
        public static void shuffle(IComparable[] a)
        {
            for(int i = 1; i < a.Length; i++)
            {
                Random r = new Random();
                int randomIndex = r.Next(0,i-1);
                a.exch(i,randomIndex);
            }
        }

        public static void ShuffleTest()
        {
            Console.WriteLine("Random Shuffle");
            string[] a = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            Console.Write("Before Shuffle: ");
            Console.Write(string.Join(" ", a));
            Console.WriteLine();
            shuffle(a);
            Console.Write("After Shuffle: ");
            Console.Write(string.Join(" ", a));
        }
    }
}
