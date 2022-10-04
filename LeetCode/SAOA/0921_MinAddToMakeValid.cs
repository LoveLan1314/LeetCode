﻿namespace LeetCode.SAOA
{
    internal sealed class MinAddToMakeValidSolution
    {
        public int MinAddToMakeValid(string s)
        {
            int ans = 0;
            int leftCount = 0;
            int length = s.Length;
            for (int i = 0; i < length; i++)
            {
                char c = s[i];
                if (c == '(')
                {
                    leftCount++;
                }
                else
                {
                    if (leftCount > 0)
                    {
                        leftCount--;
                    }
                    else
                    {
                        ans++;
                    }
                }
            }
            ans += leftCount;
            return ans;
        }
    }
}
