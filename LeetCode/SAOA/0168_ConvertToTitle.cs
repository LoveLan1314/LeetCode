using System.Text;

namespace LeetCode.SAOA
{
    internal sealed class ConvertToTitleSolution
    {
        private readonly string[] _keyValues = new string[]
        {
            "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M",
            "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"
        };

        public string ConvertToTitle(int columnNumber)
        {
            var sb = new StringBuilder();
            while (columnNumber > 0)
            {
                var key = (columnNumber - 1) % 26;
                sb.Insert(0, _keyValues[key]);
                columnNumber = (columnNumber - (key + 1)) / 26;
            }
            return sb.ToString();
        }
    }
}
