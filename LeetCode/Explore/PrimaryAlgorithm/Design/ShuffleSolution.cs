using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Explore.PrimaryAlgorithm.Design
{
    class ShuffleSolution
    {
        private readonly int[] _nums;
        public ShuffleSolution(int[] nums)
        {
            _nums = nums;
        }

        public int[] Reset()
        {
            return _nums;
        }

        public int[] Shuffle()
        {
            int[] shuffle = new int[_nums.Length];
            System.Array.Copy(_nums, shuffle, _nums.Length);
            int pos;
            int temp;
            Random random = new Random();
            for (int i = 0; i < _nums.Length; i++)
            {
                pos = random.Next(_nums.Length);
                temp = shuffle[pos];
                shuffle[pos] = shuffle[i];
                shuffle[i] = temp;
            }
            return shuffle;
        }
    }
}
