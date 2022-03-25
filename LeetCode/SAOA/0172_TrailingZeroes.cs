namespace LeetCode.SAOA
{
    internal sealed class TrailingZeroesSolution
    {
        public int TrailingZeroes(int n)
        {
            //计算一共有多少个10，2*5=10，2一定比5多，则为计算一共有多少个5
            int ans = 0;
            for (int i = 5; i <= n; i += 5)
            {
                for (int x = i; x % 5 == 0; x /= 5)
                {
                    ++ans;
                }
            }
            return ans;
        }
    }
}
