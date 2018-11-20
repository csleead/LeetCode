using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Problem809
{
    public class Solution
    {
        public IList<string> FindAndReplacePattern(string[] words, string pattern)
        {
            return words.Where(w => IsMatch(w, pattern)).ToList();
        }

        private bool IsMatch(string word, string pattern)
        {
            var wordToPattern = new Dictionary<char, char>();
            var patternToWord = new Dictionary<char, char>();
            for(int i = 0; i < word.Length; i++)
            {
                if((wordToPattern.ContainsKey(word[i]) && wordToPattern[word[i]] != pattern[i]) ||
                    (patternToWord.ContainsKey(pattern[i]) && patternToWord[pattern[i]] != word[i]))
                {
                    return false;
                }
                else
                {
                    wordToPattern.TryAdd(word[i], pattern[i]);
                    patternToWord.TryAdd(pattern[i], word[i]);
                }
            }

            return true;
        }
    }
}
