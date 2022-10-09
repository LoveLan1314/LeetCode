﻿namespace LeetCode.SAOA
{
    internal sealed class ScoreOfParenthesesSolution
    {
        public int ScoreOfParentheses(string s)
        {
            if (s.Length == 2)
            {
                return 1;
            }
            int bal = 0, n = s.Length, len = 0;
            for (int i = 0; i < n; i++)
            {
                bal += s[i] == '(' ? 1 : -1;
                if (bal == 0)
                {
                    len = i + 1;
                    break;
                }
            }
            if (len == n)
            {
                return 2 * ScoreOfParentheses(s.Substring(1, n - 2));
            }
            else
            {
                return ScoreOfParentheses(s.Substring(0, len)) + ScoreOfParentheses(s[len..]);
            }
        }
    }
}
