// <copyright file="SearchETest.cs">Copyright ©  2016</copyright>
using System;
using Algorithms.search;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.search.Tests
{
    /// <summary>This class contains parameterized unit tests for Search`1</summary>
    [PexClass(typeof(Search<>))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class SearchETest
    {
        /// <summary>Test stub for BinarySearch(!0[], !0)</summary>
        [PexGenericArguments(typeof(int))]
        [PexMethod]
        public TE BinarySearchTest<TE>(
            [PexAssumeUnderTest]Search<TE> target,
            TE[] array,
            TE item
        )
        {
            TE result = target.BinarySearch(array, item);
            return result;
            // TODO: add assertions to method SearchETest.BinarySearchTest(Search`1<!!0>, !!0[], !!0)
        }
    }
}
