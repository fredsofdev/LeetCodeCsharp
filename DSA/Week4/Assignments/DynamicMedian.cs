using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Week4.Assignments
{
    internal class DynamicMedian
    {
        private readonly MaxPQ<int> lowerHalf;
        private readonly MinPQ<int> upperHalf;

        public DynamicMedian(int capacity)
        {
            upperHalf = new MinPQ<int>(capacity);
            lowerHalf = new MaxPQ<int>(capacity);
        }

        public bool IsEmpty() => lowerHalf.IsEmpty() && upperHalf.IsEmpty();

        public void Insert(int key)
        {
            if(lowerHalf.IsEmpty() || key < lowerHalf.PeakMax())
            {
                lowerHalf.Insert(key);
            }
            else upperHalf.Insert(key);
            syncQueues();
        }

        public int FindMedian()
        {
            return lowerHalf.PeakMax();
        }

        public int RemoveMedian()
        {
            int median = lowerHalf.DelMax();
            syncQueues();
            return median;
        }

        public int RemoveEvenMedian()
        {
            if ((lowerHalf.Count + upperHalf.Count) % 2 != 0) return 0;
            return RemoveMedian();
        }



        private void syncQueues()
        {
            if(lowerHalf.Count < upperHalf.Count)
            {
                lowerHalf.Insert(upperHalf.DelMin());
            }
            else if(upperHalf.Count < lowerHalf.Count - 1)
            {
                upperHalf.Insert(lowerHalf.DelMax());
            }
        }

        public void Print()
        {
            lowerHalf.Print();
            Console.Write("|");
            upperHalf.Print();
        }

        public static void Run()
        {
            Console.WriteLine("DynamicMedian: - for peak, = for remove max");
            DynamicMedian queue = new DynamicMedian(15);
            while (true)
            {
                string? inputString = Console.ReadLine();

                if (inputString == "-")
                {
                    if (queue.IsEmpty()) continue;
                    Console.WriteLine($"=> {queue.FindMedian()}");
                }
                else if (inputString == "=")
                {
                    if (queue.IsEmpty()) continue;
                    Console.WriteLine($"=> {queue.RemoveMedian()}");
                }
                else if (inputString == null) continue;
                else if (int.TryParse(inputString, out int input))
                    queue.Insert(input);
                queue.Print();
            }
        }
    }
}
