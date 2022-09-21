﻿using System;
using System.Collections.Generic;

namespace LeetCode.SAOA
{
    internal sealed class KSimilaritySolution
    {
        public int KSimilarity(string s1, string s2)
        {
            int n = s1.Length;
            var queue = new Queue<Tuple<string, int>>();
            var visit = new HashSet<string>();
            queue.Enqueue(new Tuple<string, int>(s1, 0));
            visit.Add(s1);
            int step = 0;
            while (queue.Count > 0)
            {
                int sz = queue.Count;
                for (int i = 0; i < sz; i++)
                {
                    var tuple = queue.Dequeue();
                    string cur = tuple.Item1;
                    int pos = tuple.Item2;
                    if (cur.Equals(s2))
                    {
                        return step;
                    }
                    while (pos < n && cur[pos] == s2[pos])
                    {
                        pos++;
                    }
                    for (int j = pos + 1; j < n; j++)
                    {
                        if (s2[j] == cur[j])
                        {
                            continue;
                        }
                        if (s2[pos] == cur[j])
                        {
                            string next = Swap(cur, pos, j);
                            if (!visit.Contains(next))
                            {
                                visit.Add(next);
                                queue.Enqueue(new Tuple<string, int>(next, pos + 1));
                            }
                        }
                    }
                }
                step++;
            }
            return step;
        }

        private string Swap(string cur, int i, int j)
        {
            char[] arr = cur.ToCharArray();
            char c = arr[i];
            arr[i] = arr[j];
            arr[j] = c;
            return new string(arr);
        }
    }
}
