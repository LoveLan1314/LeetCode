namespace LeetCode.AlgorithmIntervie.String
{
    internal sealed class ReverseStringSolution
    {
        public void ReverseString(char[] s)
        {
            for (int i = 0, j = s.Length - 1; i < j; i++, j--)
            {
                char temp = s[j];
                s[j] = s[i];
                s[i] = temp;
            }
        }
    }
}
