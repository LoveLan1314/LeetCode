using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Explore.PrimaryAlgorithm.String
{
    class CountAndSaySolution
    {
        public string CountAndSay(int n)
        {
            if (n == 1) return "1";
            string s = "1";
            StringBuilder sb = new StringBuilder();
            int cnt = 0;
            while(--n > 0)
            {
                cnt = 1;
                sb.Clear();
                for (int i = 1; i < s.Length; i++)
                {
                    if(s[i] == s[i - 1])
                    {
                        cnt++;
                    }
                    else
                    {
                        sb.Append(cnt).Append(s[i - 1]);
                        cnt = 1;
                    }
                }
                sb.Append(cnt).Append(s[s.Length - 1]);
                s = sb.ToString();
            }
            return s;
        }
    }
}
