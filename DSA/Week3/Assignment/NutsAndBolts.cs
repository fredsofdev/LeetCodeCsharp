using DSA.Week2.Sort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Week3.Assignment
{
    internal class NutsAndBolts
    {
        public void MatchNutsAndBolts(int[] nuts, int[] bolts, int low, int high)
        {
            if (low < high)
            {
                // Choose the last element of bolts as pivot, partition the nuts around this bolt
                int pivot = Partition(nuts, low, high, bolts[high]);

                // Using the nut at pivot position to partition the bolts
                Partition(bolts, low, high, nuts[pivot]);

                // Recursively match the subarrays of nuts and bolts
                MatchNutsAndBolts(nuts, bolts, low, pivot - 1);
                MatchNutsAndBolts(nuts, bolts, pivot + 1, high);
            }
        }

        private int Partition(int[] arr, int low, int high, int pivot)
        {
            int i = low;
            for (int j = low; j < high; j++)
            {
                if (arr[j] < pivot)
                {
                    Swap(arr, i, j);
                    i++;
                }
                else if (arr[j] == pivot)
                {
                    Swap(arr, j, high);
                    j--;
                }
            }
            Swap(arr, i, high);
            return i;
        }

        private void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        public void PrintMatches(int[] nuts, int[] bolts)
        {
            Console.WriteLine("Matched nuts and bolts:");
            for (int i = 0; i < nuts.Length; i++)
            {
                Console.WriteLine($"Nut: {nuts[i]} - Bolt: {bolts[i]}");
            }
        }


        public static void Run()
        {
            int[] nuts = { 4, 2, 5, 3, 1 };
            int[] bolts = { 1, 3, 4, 5, 2 };

            NutsAndBolts matcher = new NutsAndBolts();
            matcher.MatchNutsAndBolts(nuts, bolts, 0, nuts.Length - 1);
            matcher.PrintMatches(nuts, bolts);
        }
    }
}
