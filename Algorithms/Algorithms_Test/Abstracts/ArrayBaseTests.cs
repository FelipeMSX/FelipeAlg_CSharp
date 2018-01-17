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
        private Comparison<ObjectTest> _comparisonObjectTest = ((x, y) =>
        {
            if (x.Id > y.Id)
                return 1;
            else
            if (x.Id < y.Id)
                return -1;
            else
                return 0;

        });

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
            ArrayBase<ObjectTest> arrayBase = Substitute.For<ArrayBase<ObjectTest>>();

            arrayBase.Comparator = _comparisonObjectTest;
            ObjectTest objectTest1 = new ObjectTest("AAA", 1);
             ObjectTest objectTest2 =  new ObjectTest("BBB", 2);
            ObjectTest objectTest3 = new ObjectTest("CCC", 3);
            arrayBase.Vector[0] = objectTest1;
            arrayBase.Vector[1] = objectTest2;
            arrayBase.Vector[2] = objectTest2;
            arrayBase.Length.Returns(3);
    
            //Act
            ObjectTest objectTestResult = arrayBase.Retrive(new ObjectTest("AAA", 1));
            //Assert
            Assert.Equals(objectTest1,objectTestResult);
        }

        [TestMethod]
        public void Retrive_ComparerNotSet_ObjectNotFound()
        {
            ArrayBase<ObjectTest> staticStruct = Substitute.For<ArrayBase<ObjectTest>>();
        }
    }
}
