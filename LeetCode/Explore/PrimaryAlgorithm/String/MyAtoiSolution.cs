using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Explore.PrimaryAlgorithm.String
{
    class MyAtoiSolution
    {
        public int MyAtoi(string str)
        {
            str = str.Trim();
            char[] vs = new char[256];
            if (str.Length == 0)
            {
                return 0;
            }
            for (int i = 0; i < str.Length; i++)
            {
                if((i == 0 && (str[i] == '-' || str[i] == '+')) || (str[i] >= '0' && str[i] <= '9'))
                {
                    vs[i] = str[i];
                }
                else
                {
                    break;
                }
            }
            if (!int.TryParse(new string(vs), out int result))
            {
                if(vs[0] == '-' || vs[0] == '+')
                {
                    if(vs[1] == '\0')
                    {
                        result = 0;
                    }
                    else
                    {
                        if(vs[0] == '+')
                        {
                            result = int.MaxValue;
                        }
                        else
                        {
                            result = int.MinValue;
                        }
                    }
                }
                else
                {
                    if(vs[0] == '\0')
                    {
                        result = 0;
                    }
                    else
                    {
                        result = int.MaxValue;
                    }
                }
            }
            return result;
        }
    }
}
