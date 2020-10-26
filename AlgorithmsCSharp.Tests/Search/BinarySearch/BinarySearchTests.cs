using System;
using System.Linq;
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
        public void BinarySearchIterEmptyTest() =>                    
            Assert.IsNull(BinarySearch.BinarySearchIter<int>(new List<int>(), 3, comparer));
        

        [Test]
        public void BinarySearchIterSomeVariantsOfArrays()
        {
            Enumerable.Range(1, 7).ToList().ForEach(
                s => {
                    var tmp = Enumerable.Range(1, s).ToList();
                    for(int i = 0; i < tmp.Count(); i++)
                    {
                        Assert.AreEqual(
                            BinarySearch.BinarySearchIter<int>(tmp, tmp[i], comparer),
                            i
                        );
                    }
                    Assert.IsNull(BinarySearch.BinarySearchIter<int>(tmp, s + 1, comparer));
                }                
            );           
       }

        [Test]
        public void BinarySearchRecursEmptyTest() =>                    
            Assert.IsNull(BinarySearch.BinarySearchRecurs<int>(new List<int>(), 3, comparer));

        [Test]
        public void BinarySearchRecursSomeVariantsOfArrays()
        {
            Enumerable.Range(1, 7).ToList().ForEach(
                s => {
                    var tmp = Enumerable.Range(1, s).ToList();
                    for(int i = 0; i < tmp.Count(); i++)
                    {                        
                        Assert.AreEqual(
                            BinarySearch.BinarySearchRecurs<int>(tmp, tmp[i], comparer),
                            i
                        );
                    }
                    Assert.IsNull(BinarySearch.BinarySearchRecurs<int>(tmp, s + 1, comparer));
                }                
            );           
       }

    }
}