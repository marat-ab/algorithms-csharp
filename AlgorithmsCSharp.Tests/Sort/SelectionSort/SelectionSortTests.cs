using System;
using System.Linq;
using System.Collections.Generic;

using NUnit.Framework;
using AlgorithmsCSharp.Sort.SelectionSort;

namespace AlgorithmsCSharp.Tests
{
    public class SelectionSortTests
    {
        IComparer<int> comparer = Comparer<int>.Create((a, b) => a < b ? -1 : (a > b ? 1 : 0));

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void SelectionSortImmutableEmptyTest() =>
            Assert.AreEqual(SelectionSort.SelectionSortImmutableForValueTypes(new List<int>(), comparer), new List<int>());

        [Test]
        public void SelectionSortImmutableOneElementTest() =>
            Assert.AreEqual(SelectionSort.SelectionSortImmutableForValueTypes(new List<int>() { 1 }, comparer), new List<int>() { 1 });

        [Test]
        public void SelectionSortImmutableSimpleArrayTest() =>
            Assert.AreEqual(SelectionSort.SelectionSortImmutableForValueTypes(new List<int>() { 3, 2, 5, 1, 6, 8, 9, 4, 7 }, comparer),
                new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 }
                );

        [Test]
        public void SelectionSortImmutableArrayWithDoublesTest() =>
            Assert.AreEqual(SelectionSort.SelectionSortImmutableForValueTypes(new List<int>() { 3, 2, 3, 1, 4, 2, 1, 4 }, comparer),
                new List<int>() { 1, 1, 2, 2, 3, 3, 4, 4 }
                );

        [Test]
        public void SelectionSortImmutableSomeArraysTest()
        {
            for (int s = 1; s < 10; s++)
            {
                var arr = Enumerable.Range(1, s).ToList();
                var tmpArr = arr.Select(item => item).ToList();
                Shuffle(tmpArr);
                Assert.AreEqual(SelectionSort.SelectionSortImmutableForValueTypes(tmpArr, comparer), arr);
            }
        }

        [Test]
        public void SelectionSortMutableEmptyTest()
        {
            var arr = new List<int>();
            SelectionSort.SelectionSortMutable(arr, comparer);
            Assert.AreEqual(arr, new List<int>());
        }

        [Test]
        public void SelectionSortMutableOneElementTest()
        {
            var arr = new List<int>() { 1 };
            SelectionSort.SelectionSortMutable(arr, comparer);
            Assert.AreEqual(arr, new List<int>() { 1 });
        }

        [Test]
        public void SelectionSortMutableSimpleArrayTest()
        {
            var arr = new List<int>() { 3, 2, 5, 1, 6, 8, 9, 4, 7 };
            SelectionSort.SelectionSortMutable(arr, comparer);
            Assert.AreEqual(arr, new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
        }

        [Test]
        public void SelectionSortMutableArrayWithDoublesTest()
        {
            var arr = new List<int>() { 3, 2, 3, 1, 4, 2, 1, 4 };
            SelectionSort.SelectionSortMutable(arr, comparer);
            Assert.AreEqual(arr, new List<int>() { 1, 1, 2, 2, 3, 3, 4, 4 });
        }

        [Test]
        public void SelectionSortMutableSomeArraysTest()
        {
            for (int s = 1; s < 10; s++)
            {
                var arr = Enumerable.Range(1, s).ToList();
                var tmpArr = arr.Select(item => item).ToList();
                Shuffle(tmpArr);
                SelectionSort.SelectionSortMutable(tmpArr, comparer);
                Assert.AreEqual(tmpArr, arr);
            }
        }


        private Random rng = new Random();
        private void Shuffle<T>(IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

    }
}