namespace LeetCode.SAOA
{
    internal sealed class _1250_IsGoodArraySolution
    {
        public bool IsGoodArray(int[] nums)
        {
            int divisor = nums[0];
            foreach (int num in nums)
            {
                divisor = GCD(divisor, num);
                if (divisor == 1)
                {
                    break;
                }
            }
            return divisor == 1;
        }

        private int GCD(int num1, int num2)
        {
            while (num2 != 0)
            {
                int temp = num1;
                num1 = num2;
                num2 = temp % num2;
            }
            return num1;
        }
    }
}
