using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.DataStructure.ArrayAndString
{
    internal sealed class AddBinarySolution
    {
        public string AddBinary(string a, string b)
        {
            var aList = a.ToCharArray().Reverse().ToList();
            var bList = b.ToCharArray().Reverse().ToList();
            var length = Math.Max(aList.Count, bList.Count);
            List<char> result = new List<char>();
            char carryFlag = '0';
            void AddValueToResult(char aChar, char bChar)
            {
                if (aChar == '0' && bChar == '0')
                {
                    result.Add(carryFlag);
                    carryFlag = '0';
                }
                else if (aChar == '1' && bChar == '1')
                {
                    result.Add(carryFlag);
                    carryFlag = '1';
                }
                else
                {
                    if (carryFlag == '1')
                    {
                        result.Add('0');
                    }
                    else
                    {
                        result.Add('1');
                    }
                }
            }
            for (int i = 0; i < length; i++)
            {
                if (aList.Count == i)
                {
                    for (int j = i; j < length; j++)
                    {
                        AddValueToResult(bList[j], '0');
                    }
                    break;
                }
                if (bList.Count == i)
                {
                    for (int j = i; j < length; j++)
                    {
                        AddValueToResult(aList[j], '0');
                    }
                    break;
                }
                AddValueToResult(aList[i], bList[i]);
            }
            if (carryFlag == '1')
            {
                result.Add(carryFlag);
            }
            result.Reverse();
            return new string(result.ToArray());
        }
    }
}
