﻿using System;
using System.Linq;

namespace LeetCode.SAOA
{
    internal sealed class MakesquareSolution
    {
        public bool Makesquare(int[] matchsticks)
        {
            var sum = matchsticks.Sum();
            if (sum % 4 != 0)
            {
                return false;
            }
            Array.Sort(matchsticks);
            for (int i = 0, j = matchsticks.Length - 1; i < j; i++, j--)
            {
                int temp = matchsticks[i];
                matchsticks[i] = matchsticks[j];
                matchsticks[j] = temp;
            }

            int[] edges = new int[4];
            return DFS(0, matchsticks, edges, sum / 4);
        }

        private bool DFS(int index, int[] matchsticks, int[] edges, int len)
        {
            if (index == matchsticks.Length)
            {
                return true;
            }
            for (int i = 0; i < edges.Length; i++)
            {
                edges[i] += matchsticks[index];
                if (edges[i] <= len && DFS(index + 1, matchsticks, edges, len))
                {
                    return true;
                }
                edges[i] -= matchsticks[index];
            }
            return false;
        }
    }
}
