namespace LeetCode.Explore.AdvancedAlgorithm.ArrayAndString
{
    internal class MaxAreaSolution
    {
        public int MaxArea(int[] height)
        {
            int left = 0;
            int right = height.Length - 1;
            int max = 0;
            while (left < right)
            {
                int leftLengh = height[left];
                int rightLengh = height[right];
                int area;
                if (leftLengh > rightLengh)
                {
                    area = rightLengh * (right - left);
                    right--;
                }
                else
                {
                    area = leftLengh * (right - left);
                    left++;
                }
                if (area > max)
                {
                    max = area;
                }
            }
            return max;
        }
    }
}
