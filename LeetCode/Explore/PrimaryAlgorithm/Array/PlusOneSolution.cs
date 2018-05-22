using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Explore.PrimaryAlgorithm
{
    public class PlusOneSolution
    {
        public int[] PlusOne(int[] digits)
        {
            int increase = 1;
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                int num = digits[i] + increase;
                if(num == 10)
                {
                    digits[i] = 0;
                    increase = 1;
                }
                else
                {
                    digits[i] = num;
                    increase = 0;
                }
            }
            if(increase == 1)
            {
                var list = digits.ToList();
                list.Insert(0, 1);
                digits = list.ToArray();
            }
            return digits;
        }
    }
}
