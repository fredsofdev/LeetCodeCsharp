using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Arrays
{
    internal class Fair_Candy_Swap
    {
        public int[] FairCandySwap(int[] aliceSizes, int[] bobSizes)
        {
            int aliceTotalSize = aliceSizes.Sum();
            int bobTotalSize = bobSizes.Sum();
            int target = (aliceTotalSize + bobTotalSize) / 2;

            foreach (int aliceCandyBox in aliceSizes)
            {

                int wantedBox = (bobTotalSize + aliceCandyBox) - target;
                if (wantedBox < 1) continue;
                foreach (int bobCandyBox in bobSizes)
                {
                    if (bobCandyBox == wantedBox)
                    {
                        return new int[] { aliceCandyBox, bobCandyBox };
                    }

                }
            }
            return new int[0];
        }

        public int[] FairCandySwap2(int[] aliceSizes, int[] bobSizes)
        {
            HashSet<int> swap = new HashSet<int>(bobSizes);
            int aliceTotalSize = aliceSizes.Sum();
            int bobTotalSize = bobSizes.Sum();
            
            int target = (aliceTotalSize + bobTotalSize) / 2;

            foreach (int aliceCandyBox in aliceSizes)
            {
                int wantedBox = (bobTotalSize + aliceCandyBox) - target;
                if (wantedBox < 1) continue;
                if(swap.Contains(wantedBox)) return new int[] { aliceCandyBox, wantedBox };
            }
            return new int[0];
        }
    }
}
