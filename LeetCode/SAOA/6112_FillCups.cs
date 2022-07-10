using System;

namespace LeetCode.SAOA
{
    internal sealed class FillCupsSolution
    {
        public int FillCups(int[] amount)
        {
            int count = 0;
            var zeroCount = 0;
            void calcZeroCount()
            {
                foreach (var item in amount)
                {
                    if (item == 0)
                    {
                        zeroCount++;
                    }
                }
            }
            calcZeroCount();
            while (zeroCount < 2)
            {
                Array.Sort(amount);
                Array.Reverse(amount);
                amount[0]--;
                amount[1]--;
                count++;
                calcZeroCount();
            }
            Array.Sort(amount);
            Array.Reverse(amount);
            return count + amount[0];
        }
    }
}
