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
            StaticStruct<ObjectTest> staticStruct = Substitute.For<StaticStruct<ObjectTest>>();
        }

        [TestMethod]
        public void Retrive_ComparerNotSet_ComparerNotSetException()
        {
            StaticStruct<ObjectTest> staticStruct = Substitute.For<StaticStruct<ObjectTest>>();
        }

        [TestMethod]
        public void Retrive_ComparerNotSet_ObjectNotFound()
        {
            StaticStruct<ObjectTest> staticStruct = Substitute.For<StaticStruct<ObjectTest>>();
        }
    }
}
