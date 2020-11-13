using System;
using System.Linq;
using System.Collections.Generic;

using NUnit.Framework;
using AlgorithmsCSharp.Sort.QuickSort;

namespace AlgorithmsCSharp.Tests
{
    public class QuickSortTests
    {
        IComparer<int> comparer = Comparer<int>.Create((a, b) => a < b ? -1 : (a > b ? 1 : 0));

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void QuickSortImmutableEmptyTest() =>
            Assert.AreEqual(QuickSort.QuickSortImmutable(new List<int>(), comparer), new List<int>());

        [Test]
        public void QuickSortImmutableOneElementTest() =>
            Assert.AreEqual(QuickSort.QuickSortImmutable(new List<int>() { 1 }, comparer), new List<int>() { 1 });

        [Test]
        public void QuickSortImmutableSimpleArrayTest() =>
            Assert.AreEqual(QuickSort.QuickSortImmutable(new List<int>() { 3, 2, 5, 1, 6, 8, 9, 4, 7 }, comparer),
                new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 }
                );

        [Test]
        public void QuickSortImmutableArrayWithDoublesTest() =>
            Assert.AreEqual(QuickSort.QuickSortImmutable(new List<int>() { 3, 2, 3, 1, 4, 2, 1, 4 }, comparer),
                new List<int>() { 1, 1, 2, 2, 3, 3, 4, 4 }
                );
    }
}