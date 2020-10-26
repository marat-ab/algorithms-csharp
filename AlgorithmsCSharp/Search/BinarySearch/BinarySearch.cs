using System;
using System.Linq;
using System.Collections.Generic;

namespace AlgorithmsCSharp.Search.BinarySearch
{
    public class BinarySearch
    {
        public static int? BinarySearchIter<T>(List<T> arr, T item, IComparer<T> comparer)
        {
            if (arr.Count == 0) { return null; }

            var low = 0;
            var high = arr.Count - 1;

            while (low <= high)
            {
                int mid = (int)Math.Floor((decimal)((low + high) / 2));
                if (comparer.Compare(arr[mid], item) < 0) { low = mid + 1; }
                else if (comparer.Compare(arr[mid], item) > 0) { high = mid - 1; }
                else { return mid; }
            }

            return null;
        }

        public static int? BinarySearchRecurs<T>(List<T> arr, T item, IComparer<T> comparer, int low = -1, int high = -1)
        {
            if (arr.Count == 0 || low > high) { return null; }

            // Init for first run
            if (low == -1 && high == -1)
            {
                low = 0;
                high = arr.Count - 1;
            }

            var mid = (int)Math.Floor((decimal)((low + high) / 2));

            if (comparer.Compare(arr[mid], item) < 0) { return BinarySearchRecurs(arr, item, comparer, mid + 1, high); }
            else if (comparer.Compare(arr[mid], item) > 0) { return BinarySearchRecurs(arr, item, comparer, low, mid - 1); }
            else { return mid; }
        }
    }
}