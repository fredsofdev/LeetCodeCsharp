using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCsharp.Top150
{
    internal class _68_TextJustification
    {

        public IList<string> FullJustify(string[] words, int maxWidth)
        {
            List<string> result = new();

            List<string> line = new();
            int lineWidth = 0;
            int wordsWidth = 0;

            for(int i= 0; i< words.Length; i++)
            {
                string word = words[i];
                bool isLast = i == words.Length - 1;
                int wordSize = lineWidth == 0 ? word.Length : word.Length + 1;
                if(lineWidth + wordSize <= maxWidth)
                {
                    lineWidth += wordSize;
                    wordsWidth += word.Length;
                    line.Add(word);
                    if(!isLast) continue;
                }
                else
                {

                }

                int totalSpace = maxWidth - wordsWidth;
                int space = totalSpace;
                if (line.Count == 1)
                {
                    result.Add(line[0] + new string(' ', totalSpace));
                    continue;
                }
                else space = totalSpace / line.Count - 1;

                if(isLast) space = 1;

                string strLine = line[0];

                for(int j = 1; j < line.Count; j++)
                {
                    if(!isLast && j == line.Count - 1)
                    {
                        int needSpace = maxWidth - (strLine.Length + line[j].Length);
                        strLine += new string(' ', needSpace) + line[j];
                    }
                    else strLine += new string(' ', space) + line[j];

                    if(isLast && j == line.Count - 1)
                    {
                        int needSpace = maxWidth - strLine.Length;
                        strLine += new string(' ', needSpace);
                    }
                }
                result.Add(strLine);
                line.Clear();
                lineWidth = 0;
                wordsWidth = 0;
                if (!isLast)
                {
                    lineWidth += wordSize;
                    wordsWidth += word.Length;
                    line.Add(word);
                }
            }
            return result;
        }


        class LineInfo
        {
            public List<string> Words { get; set; } = new();
            public int WSize { get; set; } = 0;

            public int Size => WSize + Words.Count;
        }

        public IList<string> FullJustify2(string[] words, int maxWidth)
        {

            List<string> result = new();
            if(words.Length == 1)
            {
                result.Add(words[0]+ new string(' ',maxWidth - words[0].Length));
                return result;
            }

            List<LineInfo> lines = new();

            LineInfo l = new ();
            int p = 0;
            while(p < words.Length)
            {
                string word = words[p];
                if(l.Size + word.Length >= maxWidth)
                {
                    l.WSize += word.Length;
                    l.Words.Add(word);
                    if (++p != words.Length) continue;
                }
                lines.Add(l);
                l = new LineInfo();
            }


            for(int i = 0; i < lines.Count; i++)
            {
                l = lines[i];
                int totalSpace = maxWidth - l.WSize;
                
            }





            List<string> line = new();

            int lineWidth = 0;
            int wordsWidth = 0;

            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];
                bool isLast = i == words.Length - 1;
                int wordSize = lineWidth == 0 ? word.Length : word.Length + 1;
                if (lineWidth + wordSize <= maxWidth)
                {
                    lineWidth += wordSize;
                    wordsWidth += word.Length;
                    line.Add(word);
                    if (!isLast) continue;
                }
                else
                {

                }

                int totalSpace = maxWidth - wordsWidth;
                int space = totalSpace;
                if (line.Count == 1)
                {
                    result.Add(line[0] + new string(' ', totalSpace));
                    continue;
                }
                else space = totalSpace / line.Count - 1;

                if (isLast) space = 1;

                string strLine = line[0];

                for (int j = 1; j < line.Count; j++)
                {
                    if (!isLast && j == line.Count - 1)
                    {
                        int needSpace = maxWidth - (strLine.Length + line[j].Length);
                        strLine += new string(' ', needSpace) + line[j];
                    }
                    else strLine += new string(' ', space) + line[j];

                    if (isLast && j == line.Count - 1)
                    {
                        int needSpace = maxWidth - strLine.Length;
                        strLine += new string(' ', needSpace);
                    }
                }
                result.Add(strLine);
                line.Clear();
                lineWidth = 0;
                wordsWidth = 0;
                if (!isLast)
                {
                    lineWidth += wordSize;
                    wordsWidth += word.Length;
                    line.Add(word);
                }
            }
            return result;
        }

        public static void Run()
        {
            string[] words = new string[] { "This", "is", "an", "example", "of", "text", "justification." };
            int maxWidth = 16;
            var Just = new _68_TextJustification();
            var lines =  Just.FullJustify(words, maxWidth);
            foreach(string line in lines) Console.WriteLine(line);
        }
    }
}
