using System;
using System.Collections.Generic;

using NUnit.Framework;
using AlgorithmsCSharp.Search.BinarySearch;

namespace AlgorithmsCSharp.Tests
{
    public class Tests
    {
        IComparer<int> comparer = Comparer<int>.Create((a, b) => a < b ? -1 : (a > b ? 1 : 0));

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void BinarySearchIterEmptyTest()
        {
            var value = BinarySearch.BinarySearchIter<int>(new List<int>(), 3, comparer);
            Assert.IsNull(value);
        }
    }
}