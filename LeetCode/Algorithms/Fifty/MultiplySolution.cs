using System.Text;

namespace LeetCode.Algorithms.Fifty
{
    internal class MultiplySolution
    {
        public string Multiply(string num1, string num2)
        {
            int n1 = num1.Length - 1;
            int n2 = num2.Length - 1;
            if (n1 < 0 || n2 < 0)
            {
                return string.Empty;
            }
            int[] mul = new int[n1 + n2 + 2];

            for (int i = n1; i >= 0; i--)
            {
                for (int j = n2; j >= 0; j--)
                {
                    int bitmul = (num1[i] - '0') * (num2[j] - '0');
                    bitmul += mul[i + j + 1];

                    mul[i + j] += bitmul / 10;
                    mul[i + j + 1] = bitmul % 10;
                }
            }

            StringBuilder sb = new StringBuilder();
            int k = 0;
            while (k < mul.Length - 1 && mul[k] == 0)
            {
                k++;
            }
            for (; k < mul.Length; k++)
            {
                sb.Append(mul[k]);
            }
            return sb.ToString();
        }
    }
}
