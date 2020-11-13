using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.AlgorithmIntervie.Array
{
    internal sealed class ShuffleSolution
    {
        private readonly int[] _nums;
        private readonly int[] _originNums;
        private readonly Random _random = new Random();
        public ShuffleSolution(int[] nums)
        {
            _nums = nums;
            _originNums = new int[nums.Length];
            nums.CopyTo(_originNums, 0);
        }

        public int[] Reset()
        {
            return _originNums;
        }

        public int[] Shuffle()
        {
            int length = _nums.Length;
            for (int i = length; i > 0; i--)
            {
                int randInd = _random.Next(i);
                int temp = _nums[randInd];
                _nums[randInd] = _nums[i - 1];
                _nums[i - 1] = temp;
            }
            return _nums;
        }
    }
}
