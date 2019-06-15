using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Problem609
{
    public class Solution
    {
        public IList<IList<string>> FindDuplicate(string[] paths)
        {
            var dic = new Dictionary<string, IList<string>>();

            foreach(var path in paths)
            {
                foreach(var f in ParsePath(path))
                {
                    if(!dic.ContainsKey(f.Content))
                    {
                        dic[f.Content] = new List<string>();
                    }

                    var list = dic[f.Content];
                    list.Add(f.Path);
                }
            }

            return dic.Values.Where(list => list.Count >= 2).ToList();
        }

        private IEnumerable<File> ParsePath(string path)
        {
            var split = path.Split(' ');
            var dir = split[0];
            foreach(var file in split.Skip(1))
            {
                var filename = file.Substring(0, file.IndexOf('('));
                var content = file.Substring(file.IndexOf('('));

                yield return new File
                {
                    Path = dir + "/" + filename,
                    Content = content,
                };
            }
        }

        private class File
        {
            public string Path { get; set; }
            public string Content { get; set; }
        }
    }
}
