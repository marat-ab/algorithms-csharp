using System;
using System.Linq;
using System.Collections.Generic;

namespace AlgorithmsCSharp.Sort.SelectionSort
{
    public class SelectionSort
    {
        public static List<T> SelectionSortImmutableForValueTypes<T>(List<T> arr, IComparer<T> comparer)
        {
            if (arr == null || arr.Count <= 1) { return arr; }

            var tmpArr = arr.Select(item => item).ToList();

            var outArr = new List<T>();
            for (int i = 0; i < arr.Count; i++)
            {
                var minIndex = FindMinElement(tmpArr, comparer);
                outArr.Add(tmpArr[minIndex]);
                tmpArr.RemoveAt(minIndex);
            }

            return outArr;
        }

        public static void SelectionSortMutable<T>(List<T> arr, IComparer<T> comparer)
        {
            if (arr != null && arr.Count > 0)
            {                
                for(int i = 0; i < arr.Count; i++)
                {
                    var minIndex = FindMinElement(arr.TakeLast(arr.Count - i).ToList(), comparer) + i;
                    Swap(arr, minIndex, i);
                }
            }
        }

        private static void Swap<T>(List<T> arr, int firstIndex, int secondIndex)
        {
            if(firstIndex >= arr.Count || secondIndex >= arr.Count) { throw new ArgumentException(); }
            var tmp = arr[firstIndex];
            arr[firstIndex] = arr[secondIndex];
            arr[secondIndex] = tmp;

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