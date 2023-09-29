using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Arrays
{
    internal class Keyboard_Row
    {
        public string[] FindWords(string[] words)
        {
            string[] rows = new string[] {
                "qwertyuiop",
                "asdfghjkl",
                "zxcvbnm"
            };
            List<string> result = new();
            foreach (var word in words)
            {
                string workLow = word.ToLower();
                bool isInOneRow = true;
                int currentRow = 0;
                for(int i = 0; i < rows.Length; i++)
                {
                    if (rows[i].Contains(workLow.First()))
                    {
                        currentRow = i;
                        break;
                    }
                }

                foreach(char c in workLow)
                {
                    if (!rows[currentRow].Contains(c))
                    {
                        isInOneRow = false;
                    }
                }
                if (isInOneRow) result.Add(word);
            }

            return result.ToArray();
        }

        public string[] FindWords2(string[] words)
        {
            string[] rows = new string[] {
                "qwertyuiop",
                "asdfghjkl",
                "zxcvbnm"
            };
            List<string> result = new();
            foreach (var word in words)
            {
                string wordLow = word.ToLower();
                bool isInOneRow = true;
                int currentRow = 0;
                if (rows[0].Contains(wordLow[0])) currentRow = 0;
                else if (rows[1].Contains(wordLow[0])) currentRow = 1;
                else currentRow = 2;
                
                foreach (char c in wordLow)
                {
                    if (!rows[currentRow].Contains(c))
                    {
                        isInOneRow = false;
                        break;
                    }
                }
                if (isInOneRow) result.Add(word);
            }

            return result.ToArray();
        }

        public HashSet<char> row1 = new("qwertyuiopQWERTYUIOP");
        public HashSet<char> row2 = new("asdfghjklASDFGHJKL");
        public HashSet<char> row3 = new("zxcvbnmZXCVBNM");

        public string[] FindWords3(string[] words)
        {
            List<string> result = new();
            foreach (var word in words)
            {
                if (isInOneRaw(word)) 
                    result.Add(word);
            }

            return result.ToArray();
        }

        public bool isInOneRaw(string word)
        {
            HashSet<int> accouredRows = new HashSet<int>();
            foreach(char c in word)
            {
                if (row1.Contains(c)) accouredRows.Add(1);
                else if(row2.Contains(c)) accouredRows.Add(2);
                else if(row3.Contains(c)) accouredRows.Add(3);
            }
            return accouredRows.Count == 1;
        }


    }
}
