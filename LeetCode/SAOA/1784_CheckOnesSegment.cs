namespace LeetCode.SAOA
{
    internal sealed class CheckOnesSegmentSolution
    {
        public bool CheckOnesSegment(string s)
        {
            var existOne = false;
            var zeroAfterOne = false;
            foreach (var item in s)
            {
                if (item == '1')
                {
                    if (existOne && zeroAfterOne)
                    {
                        return false;
                    }
                    else
                    {
                        existOne = true;
                    }
                }
                else
                {
                    if (existOne)
                    {
                        zeroAfterOne = true;
                    }
                }
            }
            return true;
        }
    }
}
