using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problem925
{
    public class Solution
    {
        public bool IsLongPressedName(string name, string typed)
        {
            int nameIndex = 0, typedIndex = 0;
            while(nameIndex < name.Length && typedIndex < typed.Length)
            {
                var seqFromName = NextCharSequence(name, nameIndex);
                var seqFromTyped = NextCharSequence(typed, typedIndex);

                if(seqFromName.Char != seqFromTyped.Char || seqFromName.Count > seqFromTyped.Count)
                    return false;

                nameIndex += seqFromName.Count;
                typedIndex += seqFromTyped.Count;
            }

            return nameIndex == name.Length && typedIndex == typed.Length;
        }

        private CharSequence NextCharSequence(string s, int startIndex)
        {
            var c = s[startIndex];

            int i = startIndex;
            while(i + 1 < s.Length && s[i + 1] == c)
                i++;

            return new CharSequence
            {
                Char = c,
                Count = i - startIndex + 1
            };
        }

        private struct CharSequence
        {
            public char Char { get; set; }
            public int Count { get; set; }
        }
    }
}
