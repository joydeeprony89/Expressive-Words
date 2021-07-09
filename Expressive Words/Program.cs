using System;
using System.Collections.Generic;

namespace Expressive_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Heeeelllliiiiiiiiooopppp";
            string w = "Helliiiop";
            foreach(var arr in GetExpressiveWordsUnmactchCharRange(s, w))
            {
                Console.WriteLine(string.Join("-", arr));
            }
        }

        static List<int[]> GetExpressiveWordsUnmactchCharRange(string s, string w)
        {
            List<int[]> result = new List<int[]>();
            int i = 0, j = 0;
            while(i < s.Length && j < w.Length)
            {
                int len1 = MatchedCharLength(s, i);
                int len2 = MatchedCharLength(w, j);
                if (len1 > len2)
                {
                    result.Add(new int[] { i + len2, i + len1 - 1 });
                }
                i += len1;
                j += len2;
            }

            return result;
        }

        static int MatchedCharLength(string s, int i)
        {
            int itemp = i;
            while (itemp < s.Length && s[i] == s[itemp])
            {
                itemp++;
            }

            return itemp - i;
        }
    }
}
