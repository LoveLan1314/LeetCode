using System.Collections.Generic;

namespace LeetCode.Explore.IntermediateAlgorithm.Math
{
    internal class IsHappySolution
    {
        public bool IsHappy(int n)
        {
            HashSet<int> hashSet = new HashSet<int>();
            while (n != 1)
            {
                n = GetBow(n);
                if (hashSet.Contains(n))
                {
                    return false;
                }
                hashSet.Add(n);
            }
            return true;
        }

        public int GetBow(int n)
        {
            double num = 0;
            while (n != 0)
            {
                num += System.Math.Pow(n % 10, 2);
                n /= 10;
            }
            return (int)num;
        }
    }
}
