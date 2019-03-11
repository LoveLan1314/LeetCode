using System.Collections.Generic;

namespace LeetCode.Explore.AdvancedAlgorithm.ArrayAndString
{
    class FourSumCountSolution
    {
        public int FourSumCount(int[] A, int[] B, int[] C, int[] D)
        {
            Dictionary<int, int> pairs = new Dictionary<int, int>();
            for (int i = 0; i < C.Length; i++)
            {
                for (int j = 0; j < D.Length; j++)
                {
                    int key = C[i] + D[j];
                    if (!pairs.ContainsKey(key))
                    {
                        pairs.Add(key, 0);
                    }
                    pairs[key]++;
                }
            }

            int result = 0;
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < B.Length; j++)
                {
                    int key = 0 - A[i] - B[j];
                    if (pairs.ContainsKey(key))
                    {
                        result += pairs[key];
                    }
                }
            }
            return result;
        }
    }
}
