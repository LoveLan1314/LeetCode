using System;
using System.Collections.Generic;

namespace LeetCode.SAOA
{
    internal sealed class CanReorderDoubledSolution
    {
        public bool CanReorderDoubled(int[] arr)
        {
            var pairs = new Dictionary<int, int>();
            foreach (var item in arr)
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
            if(pairs.ContainsKey(0) && pairs[0] %2 != 0)
            {
                return false;
            }

            var list = new List<int>();
            foreach (var item in pairs)
            {
                list.Add(item.Key);
            }
            list.Sort((a, b) => Math.Abs(a) - Math.Abs(b));

            foreach (var item in list)
            {
                if ((pairs.ContainsKey(2 * item) ? pairs[2 * item] : 0) < pairs[item])
                { // 无法找到足够的 2x 与 x 配对
                    return false;
                }
                if (pairs.ContainsKey(2 * item))
                {
                    pairs[2 * item] -= pairs[item];
                }
                //这里不会有不存在的情况
            }

            return true;
        }
    }
}
