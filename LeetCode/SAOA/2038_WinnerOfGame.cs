﻿namespace LeetCode.SAOA
{
    internal sealed class WinnerOfGameSolution
    {
        public bool WinnerOfGame(string colors)
        {
            int[] freq = { 0, 0 };
            char cur = 'C';
            int cnt = 0;
            foreach (char c in colors)
            {
                if (c != cur)
                {
                    cur = c;
                    cnt = 1;
                }
                else
                {
                    cnt += 1;
                    if (cnt >= 3)
                    {
                        freq[cur - 'A'] += 1;
                    }
                }
            }
            return freq[0] > freq[1];
        }
    }
}
