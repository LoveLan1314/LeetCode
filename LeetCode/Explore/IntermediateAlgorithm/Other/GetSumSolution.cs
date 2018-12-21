namespace LeetCode.Explore.IntermediateAlgorithm.Other
{
    internal class GetSumSolution
    {
        public int GetSum(int a, int b)
        {
            int res = 0;
            int xor = a ^ b;

            int forward = (a & b) << 1;
            if (forward != 0)
            {
                res = GetSum(xor, forward);
            }
            else
            {
                res = xor;
            }

            return res;
        }
    }
}
