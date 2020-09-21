using System.Collections.Generic;
using System.Linq;

namespace LeetCode.AlgorithmIntervie.BeforeStart
{
    internal sealed class SingleNumberSolution
    {
        public int SingleNumber(int[] nums)
        {
            var hashSet = new HashSet<int>();
            foreach (var item in nums)
            {
                if (!hashSet.Contains(item))
                {
                    hashSet.Add(item);
                }
            }
            return hashSet.Sum() * 2 - nums.Sum();
        }

        /// <summary>
        /// 利用异或操作，相等的存在则为0
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int SingleNumber1(int[] nums)
        {
            var result = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                result ^= nums[i];
            }
            return result;
        }
    }
}
