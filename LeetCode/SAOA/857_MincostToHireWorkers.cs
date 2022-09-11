﻿using System;

namespace LeetCode.SAOA
{
    internal sealed class MincostToHireWorkersSolution
    {
        public double MincostToHireWorkers(int[] quality, int[] wage, int k)
        {
            int n = quality.Length;
            int[] h = new int[n];
            for (int i = 0; i < n; i++)
            {
                h[i] = i;
            }
            Array.Sort(h, (a, b) =>
            {
                return quality[b] * wage[a] - quality[a] * wage[b];
            });
            double res = 1e9;
            double totalq = 0.0;
            PriorityQueue<int, int> pq = new PriorityQueue<int, int>();
            for (int i = 0; i < k - 1; i++)
            {
                totalq += quality[h[i]];
                pq.Enqueue(quality[h[i]], -quality[h[i]]);
            }
            for (int i = k - 1; i < n; i++)
            {
                int idx = h[i];
                totalq += quality[idx];
                pq.Enqueue(quality[idx], -quality[idx]);
                double totalc = ((double)wage[idx] / quality[idx]) * totalq;
                res = Math.Min(res, totalc);
                totalq -= pq.Dequeue();
            }
            return res;
        }
    }

    internal class PriorityQueue<T1, T2>
    {
        internal double Dequeue()
        {
            throw new NotImplementedException();
        }

        internal void Enqueue(int v1, int v2)
        {
            throw new NotImplementedException();
        }
    }
}
