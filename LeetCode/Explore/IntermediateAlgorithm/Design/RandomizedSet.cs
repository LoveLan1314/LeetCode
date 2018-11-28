using System;
using System.Collections.Generic;

namespace LeetCode.Explore.IntermediateAlgorithm.Design
{
    internal class RandomizedSet
    {
        private readonly HashSet<int> vs = new HashSet<int>();

        public RandomizedSet()
        {

        }

        public bool Insert(int val)
        {
            return vs.Add(val);
        }

        public bool Remove(int val)
        {
            return vs.Remove(val);
        }

        public int GetRandom()
        {
            Random random = new Random();
            int target = random.Next(vs.Count);
            int index = 0;
            foreach (var item in vs)
            {
                if (index == target)
                {
                    return item;
                }
                index++;
            }
            return 0;
        }
    }
}
