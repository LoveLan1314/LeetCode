using System;
using System.Collections.Generic;

namespace LeetCode.SAOA
{
    internal sealed class CanChangeSolution
    {
        public bool CanChange(string start, string target)
        {
            HashSet<int> leftUsed = new HashSet<int>();
            int leftStart = 0;
            for (int i = 0; i < target.Length; i++)
            {
                if (target[i] == 'L')
                {
                    leftStart = Math.Max(leftStart, i);
                    bool isMatch = false;
                    for (int j = leftStart; j < start.Length; j++)
                    {
                        if (leftUsed.Contains(j))
                        {
                            continue;
                        }
                        if (start[j] == 'R')
                        {
                            return false;
                        }
                        if (start[j] == 'L')
                        {
                            leftStart = j + 1;
                            isMatch = true;
                            leftUsed.Add(j);
                            break;
                        }
                    }
                    if (!isMatch)
                    {
                        return false;
                    }
                }
            }
            for (int i = 0; i < start.Length; i++)
            {
                if (start[i] == 'L' && !leftUsed.Contains(i))
                {
                    return false;
                }
            }
            HashSet<int> rightUsed = new HashSet<int>();
            int rightStart = target.Length - 1;
            for (int i = target.Length - 1; i >= 0; i--)
            {
                if (target[i] == 'R')
                {
                    rightStart = Math.Min(i, rightStart);
                    bool isMatch = false;
                    for (int j = rightStart; j >= 0; j--)
                    {
                        if (rightUsed.Contains(j))
                        {
                            continue;
                        }
                        if (start[j] == 'L')
                        {
                            return false;
                        }
                        if (start[j] == 'R')
                        {
                            rightStart = j - 1;
                            isMatch = true;
                            rightUsed.Add(j);
                            break;
                        }
                    }
                    if (!isMatch)
                    {
                        return false;
                    }
                }
            }
            for (int i = start.Length - 1; i >= 0; i--)
            {
                if (start[i] == 'R' && !rightUsed.Contains(i))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
