using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Arrays
{
    internal class Deck_Of_Cards
    {
        public bool HasGroupsSizeX(int[] deck)
        {
            if (deck.Length <= 1) return false;
            
            Dictionary<int, int> freq = new();
            
            foreach (int num in deck)
            {
                if (freq.ContainsKey(num)) freq[num]++;
                else freq[num] = 1;
            }

            int x = freq.Values.Min();
            
            if (x < 2) return false;
            
            var dividables = new List<int>();
            for (int i = 2; i < 10; i++)
            {
                if (x % i == 0) dividables.Add(i);
            }

            foreach (int div in dividables)
            {
                bool isPossible = true;
                foreach (int frequancy in freq.Values)
                {
                    if (frequancy % div != 0)
                    {
                        isPossible = false;
                        break;
                    }
                }
                if (isPossible) return true;
            }

            return false;
        }

        public bool HasGroupsSizeX2(int[] deck)
        {
            if (deck.Length <= 1) return false;

            Dictionary<int, int> freq = new();

            foreach (int num in deck)
            {
                if (freq.ContainsKey(num)) freq[num]++;
                else freq[num] = 1;
            }

            int x = freq.Values.Min();

            if (x < 2) return false;

            var dividables = new List<int>() { 2, 3, 5, 7};

            foreach (int div in dividables)
            {
                bool isPossible = true;
                foreach (int frequancy in freq.Values)
                {
                    if (frequancy % div != 0)
                    {
                        isPossible = false;
                        break;
                    }
                }
                if (isPossible) return true;
            }

            return false;
        }

        public bool HasGroupsSizeX3(int[] deck)
        {
            if (deck.Length <= 1) return false;

            Dictionary<int, int> freq = new();

            foreach (int num in deck)
            {
                if (freq.ContainsKey(num)) freq[num]++;
                else freq[num] = 1;
            }

            int gcd = -1;
            foreach (int div in freq.Values)
            {
                if (gcd == -1) gcd = div;
                else gcd = GCD(gcd, div);
            }

            return gcd>=2;
        }

        public int GCD(int a, int b)
        {
            if(b == 0) return a;
            return GCD(b, a % b);
        }
    }
}
