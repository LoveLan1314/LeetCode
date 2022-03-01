using System.Text;

namespace LeetCode.SAOA
{
    internal sealed class ConvertSolution
    {
        public string Convert(string s, int numRows)
        {
            int n = s.Length, r = numRows;
            if (r == 1 || r >= n)
            {
                return s;
            }
            //每个周期需要的字符个数
            int t = r * 2 - 2;
            //矩阵的列数
            //n + t - 1表示总字符个数，最后一个周期视为完整周期
            //r - 1为每个周期需要的列数
            int c = (n + t - 1) / t * (r - 1);
            char[][] mat = new char[r][];
            for (int i = 0; i < r; ++i)
            {
                mat[i] = new char[c];
            }
            for (int i = 0, x = 0, y = 0; i < n; ++i)
            {
                mat[x][y] = s[i];
                //判断在周期内的位置
                if (i % t < r - 1)
                {
                    ++x; // 向下移动
                }
                else
                {
                    --x;
                    ++y; // 向右上移动
                }
            }
            StringBuilder ans = new StringBuilder();
            foreach (char[] row in mat)
            {
                foreach (char ch in row)
                {
                    if (ch != 0)
                    {
                        ans.Append(ch);
                    }
                }
            }
            return ans.ToString();
        }
    }
}
