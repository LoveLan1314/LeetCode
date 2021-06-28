using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.SAOA
{
    internal sealed class NumBusesToDestinationSolution
    {
        public int NumBusesToDestination(int[][] routes, int source, int target)
        {
            if (source == target)
            {
                return 0;
            }
            HashSet<int> set = new HashSet<int>()
            {
                source
            };
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(source);
            int step = 0;
            while (queue.Count > 0)
            {
                step++;
                int size = queue.Count;
                for (int i = 0; i < size; i++)
                {
                    var current = queue.Dequeue();
                    var nextRoutes = GetNextRoutes(routes, current);
                    for (int j = 0; j < nextRoutes.Count; j++)
                    {
                        var nextRoute = nextRoutes[j];
                        if (nextRoute == target)
                        {
                            return step;
                        }
                        if (!set.Contains(nextRoute))
                        {
                            set.Add(nextRoute);
                            queue.Enqueue(nextRoute);
                        }
                    }
                }
            }
            return -1;
        }

        private List<int> GetNextRoutes(int[][] routes, int current)
        {
            var result = new List<int>();
            for (int i = 0; i < routes.Length; i++)
            {
                if (routes[i].Contains(current))
                {
                    for (int j = 0; j < routes[i].Length; j++)
                    {
                        if (routes[i][j] != current)
                        {
                            result.Add(routes[i][j]);
                        }
                    }
                }
            }
            return result;
        }

        public int NumBusesToDestination1(int[][] routes, int source, int target)
        {
            if (source == target)
            {
                return 0;
            }

            int n = routes.Length;
            bool[,] edge = new bool[n, n];
            Dictionary<int, IList<int>> rec = new Dictionary<int, IList<int>>();
            for (int i = 0; i < n; i++)
            {
                foreach (int site in routes[i])
                {
                    IList<int> list = new List<int>();
                    if (rec.ContainsKey(site))
                    {
                        list = rec[site];
                        foreach (int j in list)
                        {
                            edge[i, j] = edge[j, i] = true;
                        }
                        rec[site].Add(i);
                    }
                    else
                    {
                        list.Add(i);
                        rec.Add(site, list);
                    }
                }
            }

            int[] dis = new int[n];
            Array.Fill(dis, -1);
            Queue<int> que = new Queue<int>();
            if (rec.ContainsKey(source))
            {
                foreach (int bus in rec[source])
                {
                    dis[bus] = 1;
                    que.Enqueue(bus);
                }
            }
            while (que.Count > 0)
            {
                int x = que.Dequeue();
                for (int y = 0; y < n; y++)
                {
                    if (edge[x, y] && dis[y] == -1)
                    {
                        dis[y] = dis[x] + 1;
                        que.Enqueue(y);
                    }
                }
            }

            int ret = int.MaxValue;
            if (rec.ContainsKey(target))
            {
                foreach (int bus in rec[target])
                {
                    if (dis[bus] != -1)
                    {
                        ret = Math.Min(ret, dis[bus]);
                    }
                }
            }
            return ret == int.MaxValue ? -1 : ret;
        }
    }
}
