using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problem804
{
    public class Solution
    {
        private static readonly string[] morse = new[] { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };

        public int UniqueMorseRepresentations(string[] words)
        {
            var set = new HashSet<string>();

            foreach(var word in words)
            {
                var wordMorse = string.Empty;
                foreach(var c in word)
                {
                    wordMorse += morse[c - 'a'];
                }

                set.Add(wordMorse);
            }

            return set.Count;
        }
    }
}
