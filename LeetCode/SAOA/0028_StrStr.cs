namespace LeetCode.SAOA
{
    internal sealed class StrStrSolution
    {
        public int StrStr(string haystack, string needle)
        {
            if (needle.Length == 0)
            {
                return 0;
            }
            for (int i = 0; i < haystack.Length; i++)
            {
                for (int j = 0; j < needle.Length && i + j < haystack.Length; j++)
                {
                    if (haystack[i + j] != needle[j])
                    {
                        break;
                    }
                    else if (j == needle.Length - 1)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
    }
}
