using System;
using System.Linq;
using System.Collections.Generic;

namespace AlgorithmsCSharp.Sort.QuickSort
{
    public class QuickSort
    {
        public static List<T> QuickSortImmutable<T>(List<T> arr, IComparer<T> comparer)
        {
            if (arr == null || arr.Count <= 1) { return arr; }

            var pivot = arr[0];
            var lowPart = QuickSortImmutable(arr.Skip(1)
                                    .Where(item => comparer.Compare(item, pivot) <= 0)
                                    .ToList()
                            , comparer);

            var highPart = QuickSortImmutable(arr.Skip(1)
                                    .Where(item => comparer.Compare(item, pivot) == 1)
                                    .ToList()
                            , comparer);

            return lowPart.Concat(new List<T>() { pivot }).Concat(highPart).ToList<T>();
        }
    }
}