using System.Collections.Generic;

namespace ConsoleApplication.Algorithms.Fifty
{
    class GenerateParentheses
    {
        public IList<string> GenerateParenthesis(int n)
        {
            List<string> result = new List<string>();
            Helper(result, "", n, n);
            return result;
        }
        private void Helper(List<string> result, string paren, int left, int right)
        {
            if (left == 0 && right == 0)
            {
                result.Add(paren);
                return;
            }
            if (left > 0)
            {
                Helper(result, paren + "(", left - 1, right);
            }
            if (right > 0 && left < right)
            {
                Helper(result, paren + ")", left, right - 1);
            }
        }
    }
}