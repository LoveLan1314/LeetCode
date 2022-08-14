using System.Text;

namespace LeetCode.SAOA
{
    internal sealed class SmallestNumberSolution
    {
        public string SmallestNumber(string pattern)
        {
            var arr = new int[pattern.Length + 1];
            var maxIIndex = -1;
            for (int i = 0; i < pattern.Length; i++)
            {
                if (pattern[i] == 'I')
                {
                    maxIIndex = i;
                }
            }
            var max = pattern.Length + 1;
            for (int i = maxIIndex; i < pattern.Length; i++)
            {
                arr[i + 1] = max--;
            }
            for (int i = 0; i < maxIIndex; i++)
            {
                if (pattern[i + 1] == 'D')
                {
                    if (i == 0)
                    {
                        arr[i] = max--;
                    }
                    arr[i + 1] = max--;
                }
            }
            for (int i = maxIIndex - 1; i >= 0; i--)
            {
                if (pattern[i + 1] == 'I')
                {
                    arr[i + 1] = max--;
                    if (i == 0)
                    {
                        arr[i] = max--;
                    }
                }
            }
            var sb = new StringBuilder();
            foreach (var item in arr)
            {
                sb.Append(item);
            }
            return sb.ToString();
        }
    }
}
