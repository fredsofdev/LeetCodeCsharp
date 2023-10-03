using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Arrays
{
    internal class Shortest_Completing_Word
    {
        public string ShortestCompletingWord(string licensePlate, string[] words)
        {
            Dictionary<int, int> buckets = new();
            var frecLicenseMap = GetFreqMap(licensePlate);

            for(int i = 0; i < words.Length; i++)
            {
                var freqMap = new Dictionary<char, int>(frecLicenseMap);
                foreach (char c in words[i])
                {
                    if (!freqMap.ContainsKey(c)) continue;
                    Console.WriteLine(c);
                    if (freqMap[c] > 1)
                        freqMap[c]--;
                    else freqMap.Remove(c);
                }
                Console.WriteLine(freqMap.Count);
                if (freqMap.Count == 0) buckets[i] = words[i].Length;
            }
            Console.WriteLine($"Buckets :{buckets.Count}");
            int minimumLenth = buckets.Values.Min();

            var possible = buckets
                .Where(x => x.Value == minimumLenth)
                .Select(x => x.Key).ToList();

            int index = possible.OrderBy(x=>x).First();
            return words[index];
        }

        public string ShortestCompletingWord2(string licensePlate, string[] words)
        {
            var frecLicenseMap = GetFreqMap(licensePlate);

            var buckets = new List<string>();

            int min = int.MaxValue;
            for (int i = 0; i < words.Length; i++)
            {
                var freqMap = GetFreqMap(words[i]);

                bool isContains = true;

                foreach (var pair in frecLicenseMap)
                {
                    if (!freqMap.ContainsKey(pair.Key) ||
                        freqMap[pair.Key] < pair.Value)
                    {
                        isContains = false;
                        break;
                    }
                }

                if (!isContains) continue;

                if (words[i].Length < min)
                {
                    min = words[i].Length;
                    buckets.Clear();
                    buckets.Add(words[i]);
                }
                else if (words[i].Length == min)
                {
                    buckets.Add(words[i]);
                }

            }
            return buckets.First();
        }

        private Dictionary<char, int> GetFreqMap(string word)
        {
            Dictionary<char, int> freqMap = new();
            foreach (char c in word)
            {
                if (!char.IsLetter(c)) continue;
                char lower = char.ToLower(c);
                if (freqMap.ContainsKey(lower)) freqMap[lower]++;
                else freqMap[lower] = 1;
            }
            return freqMap;
        }

        

    }
}
