using System;
using System.Collections.Generic;

namespace LeetCode.DataStructure.ArrayAndString
{
    internal class PlusOneSolution
    {
        public int[] PlusOne(int[] digits)
        {
            Array.Reverse(digits);
            bool plusFlag = true;
            for (int i = 0; i < digits.Length; i++)
            {
                if (plusFlag)
                {
                    if (digits[i] == 9)
                    {
                        digits[i] = 0;
                    }
                    else
                    {
                        digits[i] = digits[i] + 1;
                        plusFlag = false;
                    }
                }
            }
            if (plusFlag)
            {
                List<int> result = new List<int>(digits)
                {
                    1
                };
                result.Reverse();
                return result.ToArray();
            }
            else
            {
                Array.Reverse(digits);
                return digits;
            }
        }

        public int[] PlusOne1(int[] digits)
        {
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (digits[i] != 9)
                {
                    digits[i]++;
                    return digits;
                }
                digits[i] = 0;
            }
            //跳出for循环,说明数字全是9
            int[] temp = new int[digits.Length + 1];
            temp[0] = 1;
            return temp;
        }
    }
}
