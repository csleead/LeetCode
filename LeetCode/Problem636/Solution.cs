using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Problem636
{
    public class Solution
    {
        public int[] ExclusiveTime(int n, IList<string> logs)
        {
            var result = new int[n];

            var stack = new Stack<Log>(logs.Count / 2);

            Log previousLog = null;
            foreach(var log in logs.Select(l => new Log(l)))
            {
                if(stack.Count == 0)
                {
                    stack.Push(log);
                }
                else if(log.Event == Event.Start && previousLog.Event == Event.Start)
                {
                    var currentFunction = stack.Peek();
                    result[currentFunction.FunctionId] += log.Timestamp - previousLog.Timestamp;

                    stack.Push(log);
                }
                else if(log.Event == Event.End && previousLog.Event == Event.Start)
                {
                    var currentFunction = stack.Pop();
                    result[currentFunction.FunctionId] += log.Timestamp - previousLog.Timestamp + 1;
                }
                else if(log.Event == Event.End && previousLog.Event == Event.End)
                {
                    var currentFunction = stack.Pop();
                    result[currentFunction.FunctionId] += log.Timestamp - previousLog.Timestamp;
                }
                else if(log.Event == Event.Start && previousLog.Event == Event.End)
                {
                    var currentFunction = stack.Peek();
                    result[currentFunction.FunctionId] += log.Timestamp - previousLog.Timestamp - 1;

                    stack.Push(log);
                }

                previousLog = log;
            }

            return result;
        }

        private class Log
        {
            public int FunctionId { get; set; }
            public Event Event { get; set; }
            public int Timestamp { get; set; }

            public Log(string logString)
            {
                var firstColon = logString.IndexOf(':');
                var secondColon = logString.LastIndexOf(':');

                FunctionId = int.Parse(logString.Substring(0, firstColon));
                Event = logString.Substring(firstColon + 1, secondColon - firstColon - 1) == "start" ? Event.Start : Event.End;
                Timestamp = int.Parse(logString.Substring(secondColon + 1));
            }
        }

        private enum Event
        {
            Start,
            End
        }
    }
}
