using System;
using System.Linq;
using System.Collections.Generic;

namespace AlgorithmsCSharp.Sort.SelectionSort
{
    public class SelectionSort
    {
        public static List<T> SelectionSortImmutable<T>(List<T> arr, IComparer<T> comparer)
        {
            if (arr == null || arr.Count <= 1) { return arr; }

            var outArr = new List<T>();
            for (int i = 0; i < arr.Count; i++)
            {
                var minIndex = FindMinElement(arr.TakeLast(arr.Count - 1 - i).ToList(), comparer) + i;
                outArr.Add(arr[minIndex]);
            }

            return outArr;

        }

        private static int FindMinElement<T>(List<T> arr, IComparer<T> comparer)
        {
            if (arr == null || arr.Count == 0) { throw new ArgumentException(); }

            var minIndex = 0;
            var minElement = arr[0];
            for (var i = 0; i < arr.Count; i++)
            {
                if (comparer.Compare(arr[i], minElement) == -1)
                {
                    minElement = arr[i];
                    minIndex = i;
                }
            }

            return minIndex;
        }
    }
}