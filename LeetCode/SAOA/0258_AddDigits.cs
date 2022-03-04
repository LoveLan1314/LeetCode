namespace LeetCode.SAOA
{
    internal sealed class AddDigitsSolution
    {
        public int AddDigits(int num)
        {
            var numStr = num.ToString();
            while (numStr.Length > 1)
            {
                int value = 0;
                for (int i = 0; i < numStr.Length; i++)
                {
                    value += int.Parse(numStr[i].ToString());
                }
                numStr = value.ToString();
            }
            return int.Parse(numStr);
        }

        public int AddDigits2(int num)
        {
            while (num >= 10)
            {
                int sum = 0;
                while (num > 0)
                {
                    sum += num % 10;
                    num /= 10;
                }
                num = sum;
            }
            return num;
        }
    }
}
