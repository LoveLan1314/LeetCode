namespace LeetCode.Explore.AdvancedAlgorithm.ArrayAndString
{
    internal class ProductExceptSelfSolution
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            int[] vs = new int[nums.Length];
            vs[0] = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                vs[i] = vs[i - 1] * nums[i - 1];
            }
            int right = 1;
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                vs[i] *= right;
                right *= nums[i];
            }
            return vs;
        }
    }
}
