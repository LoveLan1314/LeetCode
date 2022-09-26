namespace LeetCode.SAOA
{
    internal sealed class MissingTwoSolution
    {
        public int[] MissingTwo(int[] nums)
        {
            int xorsum = 0;
            int n = nums.Length + 2;
            foreach (int num in nums)
            {
                xorsum ^= num;
            }
            for (int i = 1; i <= n; i++)
            {
                xorsum ^= i;
            }
            // 防止溢出
            int lsb = (xorsum == int.MinValue ? xorsum : xorsum & (-xorsum));
            int type1 = 0, type2 = 0;
            foreach (int num in nums)
            {
                if ((num & lsb) != 0)
                {
                    type1 ^= num;
                }
                else
                {
                    type2 ^= num;
                }
            }
            for (int i = 1; i <= n; i++)
            {
                if ((i & lsb) != 0)
                {
                    type1 ^= i;
                }
                else
                {
                    type2 ^= i;
                }
            }
            return new int[] { type1, type2 };
        }
    }
}
