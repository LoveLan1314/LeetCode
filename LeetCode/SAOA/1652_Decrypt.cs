namespace LeetCode.SAOA
{
    internal sealed class DecryptSolution
    {
        public int[] Decrypt(int[] code, int k)
        {
            int n = code.Length;
            int[] result = new int[n];
            if (k == 0)
            {
                return result;
            }
            for (int i = 0; i < n; i++)
            {
                if (k > 0)
                {
                    for (int j = i + 1; j < i + k + 1; j++)
                    {
                        result[i] += code[j % n];
                    }
                }
                else
                {
                    //此处k为负数
                    for (int j = i + k; j < i; j++)
                    {
                        result[i] += code[(j + n) % n];
                    }
                }
            }
            return result;
        }
    }
}
