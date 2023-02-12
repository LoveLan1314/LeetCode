﻿using System.Text;

namespace LeetCode.SAOA
{
    internal sealed class _1138_AlphabetBoardPathSolution
    {
        public string AlphabetBoardPath(string target)
        {
            int cx = 0, cy = 0;
            var res = new StringBuilder();
            foreach (char c in target)
            {
                int nx = (c - 'a') / 5;
                int ny = (c - 'a') % 5;
                if (nx < cx)
                {
                    for (int j = 0; j < cx - nx; j++)
                    {
                        res.Append('U');
                    }
                }
                if (ny < cy)
                {
                    for (int j = 0; j < cy - ny; j++)
                    {
                        res.Append('L');
                    }
                }
                if (nx > cx)
                {
                    for (int j = 0; j < nx - cx; j++)
                    {
                        res.Append('D');
                    }
                }
                if (ny > cy)
                {
                    for (int j = 0; j < ny - cy; j++)
                    {
                        res.Append('R');
                    }
                }
                res.Append('!');
                cx = nx;
                cy = ny;
            }
            return res.ToString();
        }
    }
}
