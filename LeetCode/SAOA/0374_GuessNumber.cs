namespace LeetCode.SAOA
{
    internal sealed class GuessNumberSolution : GuessGame
    {
        public int GuessNumber(int n)
        {
            int left = 1;
            int right = n;
            while (left < right)
            {
                int mid = left + (right - left) / 2;
                int value = guess(mid);
                if (value == 0)
                {
                    return mid;
                }
                else if (value > 0)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid;
                }
            }
            return left;
        }
    }
}
