using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Explore.IntermediateAlgorithm.ArrayAndString
{
    class LengthOfLongestSubstringSolution
    {
        public int LengthOfLongestSubstring(string s)
        {
            int index = 0;
            int max = 1;
            int len = s.Length;
            if (len == 0)
            {
                return 0;
            }
            if (len == 1)
            {
                return 1;
            }
            for (int i = 1; i < len; i++)
            {
                for (int j = i - 1; j >= index; j--)
                {
                    if (s[i] == s[j])
                    {
                        index = j + 1;
                        break;
                    }
                    else
                    {
                        if (max < i - j + 1)
                        {
                            max = i - j + 1;
                        }
                    }
                }
            }
            return max;
        }

        public int LengthOfLongestSubstring1(string s)
        {
            int len = s.Length;
            if (len == 0)
            {
                return 0;
            }
            Dictionary<char, int> pairs = new Dictionary<char, int>();
            int[] preArr = new int[len];
            for (int i = 0; i < len; i++)
            {
                if (pairs.TryGetValue(s[i], out int lastPosOfChar))
                {
                    int aLen = i - lastPosOfChar;
                    int bLen = preArr[i - 1] + 1;
                    if (aLen >= bLen)
                    {
                        preArr[i] = bLen;
                    }
                    else
                    {
                        preArr[i] = aLen;
                    }
                    pairs[s[i]] = i;
                }
                else
                {
                    preArr[i] = i == 0 ? 1 : preArr[i - 1] + 1;
                    pairs.Add(s[i], i);
                }
            }
            int max = preArr[0];
            for (int i = 1; i < preArr.Length; i++)
            {
                if (preArr[i] > max)
                {
                    max = preArr[i];
                }
            }
            return max;
        }
    }
}
