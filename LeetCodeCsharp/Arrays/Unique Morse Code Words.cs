using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Arrays
{
    internal class Unique_Morse_Code_Words
    {
        private readonly Dictionary<char, string> mors = new(){
         {'a',".-"},{'b',"-..."},{'c',"-.-."},{'d',"-.."},
         {'e',"."},{'f',"..-."},{'g',"--."},{'h',"...."},
         {'i',".."},{'j',".---"},{'k',"-.-"},{'l',".-.."},
         {'m',"--"},{'n',"-."},{'o',"---"},{'p',".--."},
         {'q',"--.-"},{'r',".-."},{'s',"..."},{'t',"-"},
         {'u',"..-"},{'v',"...-"},{'w',".--"},{'x',"-..-"},
         {'y',"-.--"},{'z',"--.."}};

        public int UniqueMorseRepresentations(string[] words)
        {
            var list = new HashSet<string>();
            var stringBuilder = new StringBuilder();
            foreach (string word in words)
            {
                stringBuilder.Clear();
                foreach (char c in word)
                {
                    stringBuilder.Append(mors[c]);
                }
                list.Add(stringBuilder.ToString());
            }
            return list.Count();
        }
    }
}
