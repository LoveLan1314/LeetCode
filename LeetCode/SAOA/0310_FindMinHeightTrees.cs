using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.SAOA
{
    internal sealed class FindMinHeightTreesSolution
    {
        public IList<int> FindMinHeightTrees(int n, int[][] edges)
        {
            IList<int> ans = new List<int>();
            if (n == 1)
            {
                ans.Add(0);
                return ans;
            }
            IList<int>[] adj = new IList<int>[n];
            for (int i = 0; i < n; i++)
            {
                adj[i] = new List<int>();
            }
            foreach (int[] edge in edges)
            {
                adj[edge[0]].Add(edge[1]);
                adj[edge[1]].Add(edge[0]);
            }

            int[] parent = new int[n];
            Array.Fill(parent, -1);
            /* 找到与节点 0 最远的节点 x */
            int x = FindLongestNode(0, parent, adj);
            /* 找到与节点 x 最远的节点 y */
            int y = FindLongestNode(x, parent, adj);
            /* 求出节点 x 到节点 y 的路径 */
            IList<int> path = new List<int>();
            parent[x] = -1;
            while (y != -1)
            {
                path.Add(y);
                y = parent[y];
            }
            int m = path.Count;
            if (m % 2 == 0)
            {
                ans.Add(path[m / 2 - 1]);
            }
            ans.Add(path[m / 2]);
            return ans;
        }

        private int FindLongestNode(int u, int[] parent, IList<int>[] adj)
        {
            int n = adj.Length;
            Queue<int> queue = new Queue<int>();
            bool[] visit = new bool[n];
            queue.Enqueue(u);
            visit[u] = true;
            int node = -1;

            while (queue.Count > 0)
            {
                int curr = queue.Dequeue();
                node = curr;
                foreach (int v in adj[curr])
                {
                    if (!visit[v])
                    {
                        visit[v] = true;
                        parent[v] = curr;
                        queue.Enqueue(v);
                    }
                }
            }
            return node;
        }
    }
}
