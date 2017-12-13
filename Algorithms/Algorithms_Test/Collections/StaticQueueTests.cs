using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms.Collections;
using AlgorithmsTests;

namespace Algorithms_Test.Collections
{
    [TestClass]
    public class StaticQueueTests
    {

        private StaticQueue<ObjectTest> _staticQueue;
        [TestInitialize]
        public void Initialize()
        {
            _staticQueue = new StaticQueue<ObjectTest>();
        }

        [TestMethod, TestCategory("StaticQueue")]
        public void Push_CommonObject_CrescentOrderedList()
        {
            //Arrange

            //Act
 
            //Assert

        }

        public void Push_OneObject_NoEmptyList()
        {
            //Arrange

            //Act

            //Assert

        }

        public void Push_NullValue_Exception()
        {
            //Arrange

            //Act

            //Assert

        }

        public void Push_ObjectInFullCollection_Exception()
        {
            //Arrange

            //Act

            //Assert

        }

        public void Retrieve_ObjectAfterInsert_Object()
        {
            //Arrange

            //Act

            //Assert

        }

        public void Retrieve_ObjectAfterRemove_Object()
        {
            //Arrange

            //Act

            //Assert

        }
    }
}
