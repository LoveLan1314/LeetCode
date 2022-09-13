namespace LeetCode.SAOA
{
    internal sealed class MaximumSwapSolution
    {
        public int MaximumSwap(int num)
        {
            //每一位数字应该不小于所有排它后面的数字
            char[] charArray = num.ToString().ToCharArray();
            int n = charArray.Length;
            int maxIdx = n - 1;
            int idx1 = -1, idx2 = -1;
            for (int i = n - 1; i >= 0; i--)
            {
                if (charArray[i] > charArray[maxIdx])
                {
                    maxIdx = i;
                }
                else if (charArray[i] < charArray[maxIdx])
                {
                    idx1 = i;
                    idx2 = maxIdx;
                }
            }
            if (idx1 >= 0)
            {
                char temp = charArray[idx1];
                charArray[idx1] = charArray[idx2];
                charArray[idx2] = temp;
                return int.Parse(charArray);
            }
            else
            {
                return num;
            }
        }
    }
}
