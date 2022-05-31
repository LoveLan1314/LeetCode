using System;
using System.Collections.Generic;

namespace LeetCode.SAOA
{
    internal sealed class AlienOrderSolution
    {
        const int VISITING = 1, VISITED = 2;
        private readonly Dictionary<char, IList<char>> edges = new Dictionary<char, IList<char>>();
        private readonly Dictionary<char, int> states = new Dictionary<char, int>();
        bool valid = true;
        char[] order;
        int index;

        public string AlienOrder(string[] words)
        {
            int length = words.Length;
            foreach (string word in words)
            {
                foreach (char c in word)
                {
                    if (!edges.ContainsKey(c))
                    {
                        edges.Add(c, new List<char>());
                    }
                }
            }
            for (int i = 1; i < length && valid; i++)
            {
                AddEdge(words[i - 1], words[i]);
            }
            order = new char[edges.Count];
            index = edges.Count - 1;
            Dictionary<char, IList<char>>.KeyCollection letterSet = edges.Keys;
            foreach (char u in letterSet)
            {
                if (!states.ContainsKey(u))
                {
                    DFS(u);
                }
            }
            if (!valid)
            {
                return "";
            }
            return new string(order);
        }

        private void AddEdge(string before, string after)
        {
            int length1 = before.Length, length2 = after.Length;
            int length = Math.Min(length1, length2);
            int index = 0;
            while (index < length)
            {
                char c1 = before[index], c2 = after[index];
                if (c1 != c2)
                {
                    edges[c1].Add(c2);
                    break;
                }
                index++;
            }
            if (index == length && length1 > length2)
            {
                valid = false;
            }
        }

        private void DFS(char u)
        {
            states.Add(u, VISITING);
            IList<char> adjacent = edges[u];
            foreach (char v in adjacent)
            {
                if (!states.ContainsKey(v))
                {
                    DFS(v);
                    if (!valid)
                    {
                        return;
                    }
                }
                else if (states[v] == VISITING)
                {
                    valid = false;
                    return;
                }
            }
            states[u] = VISITED;
            order[index] = u;
            index--;
        }
    }
}
