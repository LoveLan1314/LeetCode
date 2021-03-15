using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.SAOA
{
    internal sealed class FindMedianSortedArraysSolution
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int nums1Length = nums1.Length;
            int nums2Length = nums2.Length;
            int length = nums1Length + nums2Length;
            int leftKey, rightKey;
            if (length % 2 == 0)
            {
                leftKey = length / 2 - 1;
                rightKey = length / 2;
            }
            else
            {
                leftKey = length / 2;
                rightKey = leftKey;
            }
            int index = 0;
            int nums1Index = 0;
            int nums2Index = 0;
            int leftValue = 0;
            int rightValue = 0;
            while (index <= rightKey)
            {
                int value;
                if (nums1Index < nums1Length && (nums2Index >= nums2Length || nums1[nums1Index] < nums2[nums2Index]))
                {
                    value = nums1[nums1Index];
                    nums1Index++;
                }
                else
                {
                    value = nums2[nums2Index];
                    nums2Index++;
                }
                if (index == leftKey)
                {
                    leftValue = value;
                }
                if (index == rightKey)
                {
                    rightValue = value;
                }
                index++;
            }
            return (double)(leftValue + rightValue) / 2;
        }
    }
}
