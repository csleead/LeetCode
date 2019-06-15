using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Solution1024
{
    public class Solution
    {
        public int VideoStitching(int[][] clips, int T)
        {
            var longestStartWith = new Clip[T];
            Array.Fill(longestStartWith, null);

            foreach(var arr in clips)
            {
                var clip = new Clip(arr[0], arr[1]);
                if(clip.Start >= T)
                {
                    continue;
                }

                if(longestStartWith[clip.Start] == null || longestStartWith[clip.Start].Length < clip.Length)
                {
                    longestStartWith[clip.Start] = clip;
                }
            }

            int count = 0;
            int left = -1, right = 0;
            foreach(var clip in longestStartWith.Where(c => c != null))
            {
                if(clip.Start > right)
                {
                    return -1;
                }

                if(clip.End > right)
                {
                    if(clip.Start <= left)
                    {
                        right = clip.End;
                    }
                    else
                    {
                        count++;
                        left = right;
                        right = clip.End;
                    }
                }

                if(right >= T)
                {
                    return count;
                }
            }

            return -1;
        }

        private class Clip
        {
            public int Start { get; private set; }
            public int End { get; private set; }
            public int Length => End - Start;

            public Clip(int start, int end)
            {
                Start = start;
                End = end;
            }
        }
    }
}
