using System.Collections.Generic;

namespace LeetCode.SAOA
{
    internal sealed class FindClosestElementsSolution
    {
        public IList<int> FindClosestElements(int[] arr, int k, int x)
        {
            var right = BinarySearch(arr, x);
            int left = right - 1;
            while (k-- > 0)
            {
                if (left < 0)
                {
                    right++;
                }
                else if (right >= arr.Length)
                {
                    left--;
                }
                else if (x - arr[left] <= arr[right] - x)
                {
                    left--;
                }
                else
                {
                    right++;
                }
            }
            var result = new List<int>();
            for (int i = left + 1; i < right; i++)
            {
                result.Add(arr[i]);
            }
            return result;
        }

        private int BinarySearch(int[] arr, int x)
        {
            int low = 0, high = arr.Length - 1;
            while (low < high)
            {
                int mid = low + (high - low) / 2;
                if (arr[mid] >= x)
                {
                    high = mid;
                }
                else
                {
                    low = mid + 1;
                }
            }
            return low;
        }
    }
}
