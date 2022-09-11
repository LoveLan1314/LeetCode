using System.Collections.Generic;
using System.Linq;

namespace LeetCode.SAOA
{
    internal sealed class MinOperationsSolution1
    {
        public int MinOperations(int[] nums, int[] numsDivide)
        {
            var pairs = new Dictionary<int, int>();
            foreach (var item in nums)
            {
                if (pairs.ContainsKey(item))
                {
                    pairs[item]++;
                }
                else
                {
                    pairs.Add(item, 1);
                }
            }
            var deleteCount = 0;
            foreach (var item in pairs.OrderBy(i => i.Key))
            {
                var allCanDivide = true;
                foreach (var value in numsDivide)
                {
                    if (value % item.Key != 0)
                    {
                        allCanDivide = false;
                        break;
                    }
                }
                if (allCanDivide)
                {
                    return deleteCount;
                }
                else
                {
                    deleteCount += item.Value;
                }
            }
            return -1;
        }
    }
}
