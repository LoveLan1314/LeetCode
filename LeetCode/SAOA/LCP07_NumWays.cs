using System.Collections.Generic;

namespace LeetCode.SAOA
{
    internal sealed class NumWaysSolution1
    {
        public int NumWays(int n, int[][] relation, int k)
        {
            Queue<int> queue = new Queue<int>();
            int target = n - 1;
            queue.Enqueue(0);
            int step = 0;
            int result = 0;
            while (queue.Count > 0)
            {
                step++;
                int size = queue.Count;
                for (int i = 0; i < size; i++)
                {
                    int value = queue.Dequeue();
                    for (int j = 0; j < relation.Length; j++)
                    {
                        if (relation[j][0] == value)
                        {
                            if (step == k)
                            {
                                if (relation[j][1] == target)
                                {
                                    result++;
                                }
                            }
                            else
                            {
                                queue.Enqueue(relation[j][1]);
                            }
                        }
                    }
                }
            }
            return result;
        }
    }
}
