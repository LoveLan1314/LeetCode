namespace LeetCode.SAOA
{
    internal sealed class _2011_FinalValueAfterOperationsSolution
    {
        public int FinalValueAfterOperations(string[] operations)
        {
            int result = 0;
            foreach (string operation in operations)
            {
                if (operation[0] == '+' || operation[2] == '+')
                {
                    result++;
                }
                else if (operation[0] == '-' || operation[2] == '-')
                {
                    result--;
                }
            }
            return result;
        }
    }
}
