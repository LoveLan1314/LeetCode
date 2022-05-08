﻿using System.Collections.Generic;
using System.Text;

namespace LeetCode.SAOA
{
    internal sealed class MinMutationSolution
    {
        public int MinMutation(string start, string end, string[] bank)
        {
            ISet<string> cnt = new HashSet<string>();
            ISet<string> visited = new HashSet<string>();
            char[] keys = { 'A', 'C', 'G', 'T' };
            foreach (string w in bank)
            {
                cnt.Add(w);
            }
            if (start.Equals(end))
            {
                return 0;
            }
            if (!cnt.Contains(end))
            {
                return -1;
            }
            Queue<string> queue = new Queue<string>();
            queue.Enqueue(start);
            visited.Add(start);
            int step = 1;
            while (queue.Count > 0)
            {
                int sz = queue.Count;
                for (int i = 0; i < sz; i++)
                {
                    string curr = queue.Dequeue();
                    for (int j = 0; j < 8; j++)
                    {
                        for (int k = 0; k < 4; k++)
                        {
                            if (keys[k] != curr[j])
                            {
                                StringBuilder sb = new StringBuilder(curr);
                                sb.Replace(curr[j], keys[k], j, 1);
                                string next = sb.ToString();
                                if (!visited.Contains(next) && cnt.Contains(next))
                                {
                                    if (next.Equals(end))
                                    {
                                        return step;
                                    }
                                    queue.Enqueue(next);
                                    visited.Add(next);
                                }
                            }
                        }
                    }
                }
                step++;
            }
            return -1;
        }
    }
}
