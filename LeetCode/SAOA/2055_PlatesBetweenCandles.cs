namespace LeetCode.SAOA
{
    internal sealed class PlatesBetweenCandlesSolution
    {
        public int[] PlatesBetweenCandles(string s, int[][] queries)
        {
            var result = new int[queries.GetLength(0)];

            var n = s.Length;
            int[] preSum = new int[n];
            for (int i = 0, sum = 0; i < n; i++)
            {
                if (s[i] == '*')
                {
                    sum++;
                }
                preSum[i] = sum;
            }

            var leftArray = new int[n];
            var rightArray = new int[n];

            //左边和自身最近的蜡烛的index
            int leftValue = -1;
            for (int i = 0; i < n; i++)
            {
                if (s[i] == '|')
                {
                    leftValue = i;
                }
                leftArray[i] = leftValue;
            }

            //右边和自身最近的蜡烛的index
            int rightValue = -1;
            for (int i = n - 1; i >= 0; i--)
            {
                if (s[i] == '|')
                {
                    rightValue = i;
                }
                rightArray[i] = rightValue;
            }

            for (int i = 0; i < queries.GetLength(0); i++)
            {
                result[i] = 0;
                var left = queries[i][0];
                var right = queries[i][1];

                //通过这种方式对取到的范围进行限定
                //右端点最左侧所对应第一个蜡烛，可以得到最左侧蜡烛所在的index
                int x = rightArray[left];
                //左端点最右侧侧所对应第一个蜡烛，可以得到最右侧蜡烛所在的index
                int y = leftArray[right];
                result[i] = x == -1 || y == -1 || x >= y ? 0 : preSum[y] - preSum[x];
            }

            return result;
        }
    }
}
