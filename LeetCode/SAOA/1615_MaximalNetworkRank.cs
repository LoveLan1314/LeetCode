﻿using System;

namespace LeetCode.SAOA
{
    internal sealed class _1615_MaximalNetworkRankSolution
    {
        public int MaximalNetworkRank(int n, int[][] roads)
        {
            var connect = new bool[n][];
            for (int i = 0; i < n; i++)
            {
                connect[i] = new bool[n];
            }
            int[] degree = new int[n];
            foreach (int[] v in roads)
            {
                connect[v[0]][v[1]] = true;
                connect[v[1]][v[0]] = true;
                degree[v[0]]++;
                degree[v[1]]++;
            }

            int maxRank = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    int rank = degree[i] + degree[j] - (connect[i][j] ? 1 : 0);
                    maxRank = Math.Max(maxRank, rank);
                }
            }
            return maxRank;
        }
    }
}
