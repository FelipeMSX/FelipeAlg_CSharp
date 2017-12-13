using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using Algorithms.Abstacts;
using AlgorithmsTests;

namespace Algorithms_Test.Abstracts
{
    [TestClass]
    public class StaticStructTests
    {
        [TestMethod]
        public void Retrive_EmptyList_EmptyCollectionException()
        {
            ArrayBase<ObjectTest> staticStruct = Substitute.For<ArrayBase<ObjectTest>>();
        }

        [TestMethod]
        public void Retrive_ComparerNotSet_ComparerNotSetException()
        {
            ArrayBase<ObjectTest> staticStruct = Substitute.For<ArrayBase<ObjectTest>>();
        }

        [TestMethod]
        public void Retrive_ComparerNotSet_ObjectNotFound()
        {
            ArrayBase<ObjectTest> staticStruct = Substitute.For<ArrayBase<ObjectTest>>();
        }
    }
}
