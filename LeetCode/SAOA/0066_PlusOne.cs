using System.Collections.Generic;

namespace LeetCode.SAOA
{
    internal sealed class PlusOneSolution
    {
        public int[] PlusOne(int[] digits)
        {
            bool needAdd = true;
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                int value = digits[i];
                if (needAdd)
                {
                    if (value == 9)
                    {
                        digits[i] = 0;
                    }
                    else
                    {
                        digits[i] = value + 1;
                        needAdd = false;
                        break;
                    }
                }
            }
            if (needAdd)
            {
                var list = new List<int>() { 1 };
                list.AddRange(digits);
                return list.ToArray();
            }
            else
            {
                return digits;
            }
        }
    }
}
