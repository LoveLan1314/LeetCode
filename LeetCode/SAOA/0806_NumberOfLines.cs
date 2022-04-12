namespace LeetCode.SAOA
{
    internal sealed class NumberOfLinesSolution
    {
        public int[] NumberOfLines(int[] widths, string s)
        {
            int length = 1;
            int count = 0;
            foreach (var item in s)
            {
                var itemLength = widths[item - 97];
                if (count + itemLength > 100)
                {
                    length++;
                    count = 0;
                }
                count += itemLength;
            }
            return new int[] { length, count };
        }
    }
}
