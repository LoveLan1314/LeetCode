using System;
using System.Linq;

namespace LeetCode.SAOA
{
    internal sealed class CanBeEqualSolution
    {
        public bool CanBeEqual(int[] target, int[] arr)
        {
            Array.Sort(target);
            Array.Sort(arr);
            return target.SequenceEqual(arr);
        }
    }
}
