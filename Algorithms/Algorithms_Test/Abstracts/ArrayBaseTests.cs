using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using Algorithms.Abstacts;
using AlgorithmsTests;
using Algorithms.Exceptions;

namespace Algorithms_Test.Abstracts
{
    [TestClass]
    public class ArrayBaseTests
    {
     
        [TestMethod, TestCategory("ArrayBase"), ExpectedException(typeof(EmptyCollectionException))]
        public void Retrive_EmptyList_EmptyCollectionException()
        {
            //Arrange
            ArrayBase<ObjectTest> staticStruct = Substitute.For<ArrayBase<ObjectTest>>();
            //Act
            staticStruct.Retrive(new ObjectTest("AAA", 1));
            //Assert
            Assert.Inconclusive("Era esperado uma exceção do tipo EmptyCollectionException!");
        }

        [TestMethod]
        public void Retrive_ComparerNotSet_ComparerNotSetException()
        {
            //Arrange
            ArrayBase<ObjectTest> staticStruct = Substitute.For<ArrayBase<ObjectTest>>();
            //Act
            staticStruct.Retrive(new ObjectTest("AAA", 1));
            //Assert
            Assert.Inconclusive("Era esperado uma exceção do tipo EmptyCollectionException!");
        }

        [TestMethod]
        public void Retrive_ComparerNotSet_ObjectNotFound()
        {
            ArrayBase<ObjectTest> staticStruct = Substitute.For<ArrayBase<ObjectTest>>();
        }
    }
}
