using System;
using System.Collections.Generic;

namespace AlgorithmsCSharp.Search.BinarySearch
{
    public class BinarySearch
    {
        public static int? BinarySearchIter<T>(List<T> arr, T item, IComparer<T> comparer)
        {
            if(arr.Count == 0)
            {
                return null;
            }

            var low = 0;
            var high = arr.Count - 1;

            while(low <= high)
            {
                int mid = (int)Math.Floor((decimal)((low + high) / 2));
                if(comparer.Compare(arr[mid], item) < 0)
                {
                    low = mid + 1;
                }
                else if(comparer.Compare(arr[mid], item) > 0)
                {
                    high = mid - 1;
                }
                else
                {
                    return mid;
                }
            }

            return null;
        }
    }
}