using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Explore.PrimaryAlgorithm.Others
{
    class GenerateSolution
    {
        public IList<IList<int>> Generate(int numRows)
        {
            List<IList<int>> result = new List<IList<int>>();
            if (numRows >= 1)
            {
                result.Add(new List<int>() { 1 });
            }
            if (numRows >= 2)
            {
                result.Add(new List<int>() { 1, 1 });
            }
            if (numRows >= 3)
            {
                for (int i = 3; i <= numRows; i++)
                {
                    List<int> data = new List<int>() { 1 };
                    IList<int> prev = result[i - 2];
                    for (int j = 1; j < i - 1; j++)
                    {
                        data.Add(prev[j - 1] + prev[j]);
                    }
                    data.Add(1);
                    result.Add(data);
                }
            }
            return result;
        }
    }
}
