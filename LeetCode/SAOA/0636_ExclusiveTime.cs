﻿using System.Collections.Generic;

namespace LeetCode.SAOA
{
    internal sealed class ExclusiveTimeSolution
    {
        public int[] ExclusiveTime(int n, IList<string> logs)
        {
            var stack = new Stack<int[]>(); // {idx, 开始运行的时间}
            int[] res = new int[n];
            foreach (string log in logs)
            {
                int idx = int.Parse(log.Substring(0, log.IndexOf(':')));
                string type = log.Substring(log.IndexOf(':') + 1, log.LastIndexOf(':') - log.IndexOf(':') - 1);
                int timestamp = int.Parse(log[(log.LastIndexOf(':') + 1)..]);
                if ("start".Equals(type))
                {
                    if (stack.Count > 0)
                    {
                        res[stack.Peek()[0]] += timestamp - stack.Peek()[1];
                        stack.Peek()[1] = timestamp;
                    }
                    stack.Push(new int[] { idx, timestamp });
                }
                else
                {
                    int[] t = stack.Pop();
                    res[t[0]] += timestamp - t[1] + 1;
                    if (stack.Count > 0)
                    {
                        stack.Peek()[1] = timestamp + 1;
                    }
                }
            }
            return res;
        }
    }
}
