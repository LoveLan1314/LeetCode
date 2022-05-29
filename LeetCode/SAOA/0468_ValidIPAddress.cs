﻿namespace LeetCode.SAOA
{
    internal sealed class ValidIPAddressSolution
    {
        public string ValidIPAddress(string queryIP)
        {
            if (queryIP.Contains('.'))
            {
                // IPv4
                int last = -1;
                for (int i = 0; i < 4; ++i)
                {
                    int cur = (i == 3 ? queryIP.Length : queryIP.IndexOf('.', last + 1));
                    if (cur < 0)
                    {
                        return "Neither";
                    }
                    if (cur - last - 1 < 1 || cur - last - 1 > 3)
                    {
                        return "Neither";
                    }
                    int addr = 0;
                    for (int j = last + 1; j < cur; ++j)
                    {
                        if (!char.IsDigit(queryIP[j]))
                        {
                            return "Neither";
                        }
                        addr = addr * 10 + (queryIP[j] - '0');
                    }
                    if (addr > 255)
                    {
                        return "Neither";
                    }
                    if (addr > 0 && queryIP[last + 1] == '0')
                    {
                        return "Neither";
                    }
                    if (addr == 0 && cur - last - 1 > 1)
                    {
                        return "Neither";
                    }
                    last = cur;
                }
                return "IPv4";
            }
            else
            {
                // IPv6
                int last = -1;
                for (int i = 0; i < 8; ++i)
                {
                    int cur = (i == 7 ? queryIP.Length : queryIP.IndexOf(':', last + 1));
                    if (cur < 0)
                    {
                        return "Neither";
                    }
                    if (cur - last - 1 < 1 || cur - last - 1 > 4)
                    {
                        return "Neither";
                    }
                    for (int j = last + 1; j < cur; ++j)
                    {
                        if (!char.IsDigit(queryIP[j]) && !('a' <= char.ToLower(queryIP[j]) && char.ToLower(queryIP[j]) <= 'f'))
                        {
                            return "Neither";
                        }
                    }
                    last = cur;
                }
                return "IPv6";
            }
        }
    }
}
