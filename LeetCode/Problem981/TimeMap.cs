using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Problem981
{
    public class TimeMap
    {
        private readonly Dictionary<string, List<Entry>> _dic = new Dictionary<string, List<Entry>>();

        public void Set(string key, string value, int timestamp)
        {
            if(!_dic.ContainsKey(key))
            {
                _dic[key] = new List<Entry>();
            }

            _dic[key].Add(new Entry { Value = value, Timestamp = timestamp });
        }

        public string Get(string key, int timestamp)
        {
            if(_dic.TryGetValue(key, out var list))
            {
                var index = list.BinarySearch(new Entry { Timestamp = timestamp });
                if(index >= 0)
                {
                    return list[index].Value;
                }
                else
                {
                    var nextLargerIndex = ~index;
                    return nextLargerIndex == 0 ? string.Empty : list[nextLargerIndex - 1].Value;
                }
            }

            return string.Empty;
        }

        private class Entry : IComparable<Entry>
        {
            public string Value { get; set; }
            public int Timestamp { get; set; }

            public int CompareTo(Entry other) => Timestamp - other.Timestamp;

            public override string ToString() => $"{Timestamp}:{Value}";
        }
    }
}
