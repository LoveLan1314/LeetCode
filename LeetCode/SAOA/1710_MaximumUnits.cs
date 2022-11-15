using System;

namespace LeetCode.SAOA
{
    internal sealed class MaximumUnitsSolution
    {
        public int MaximumUnits(int[][] boxTypes, int truckSize)
        {
            Array.Sort(boxTypes, (a, b) => b[1] - a[1]);
            int result = 0;
            foreach (var item in boxTypes)
            {
                int numberOfBoxes = item[0];
                int numberOfUnitsPerBox = item[1];
                if (numberOfBoxes < truckSize)
                {
                    result += numberOfBoxes * numberOfUnitsPerBox;
                    truckSize -= numberOfBoxes;
                }
                else
                {
                    result += truckSize * numberOfUnitsPerBox;
                    break;
                }
            }
            return result;
        }
    }
}
