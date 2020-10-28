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
            Assert.AreEqual(SelectionSort.SelectionSortImmutable(new List<int>(), comparer), new List<int>());

    }
}