using System;

namespace LeetCode.AlgorithmIntervie.StackAndArray
{
    internal sealed class FindKthLargestSolution
    {
        private readonly Random _random = new Random();
        public int FindKthLargest(int[] nums, int k)
        {
            return QuickSelect(nums, 0, nums.Length - 1, nums.Length - k);
        }

        private int QuickSelect(int[] a, int l, int r, int index)
        {
            int q = RandomPartition(a, l, r);
            if (q == index)
            {
                return a[q];
            }
            else
            {
                return q < index ? QuickSelect(a, q + 1, r, index) : QuickSelect(a, l, q - 1, index);
            }
        }

        private int RandomPartition(int[] a, int l, int r)
        {
            int i = _random.Next(r - l + 1) + l;
            Swap(a, i, r);
            return Partition(a, l, r);
        }

        public int Partition(int[] a, int l, int r)
        {
            int x = a[r], i = l - 1;
            for (int j = l; j < r; ++j)
            {
                if (a[j] <= x)
                {
                    Swap(a, ++i, j);
                }
            }
            Swap(a, i + 1, r);
            return i + 1;
        }

        private void Swap(int[] a, int i, int j)
        {
            int temp = a[i];
            a[i] = a[j];
            a[j] = temp;
        }
    }
}
