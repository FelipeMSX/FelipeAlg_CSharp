using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms.Collections;
using AlgorithmsTests;
using Algorithms.Exceptions;

namespace Algorithms_Test.Collections
{
    [TestClass]
    public class StaticQueueTests
    {

        private StaticQueue<ObjectTest> _staticQueue;

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

        [TestInitialize]
        public void Initialize()
        {
            _staticQueue = new StaticQueue<ObjectTest>(100,true,_comparisonObjectTest);
        }

        [TestMethod, TestCategory("StaticQueue")]
        public void Push_CommonObjects_CrescentOrderedList()
        {
            //Arrange --Configurado no Initialize

            //Act
            _staticQueue.Push(new ObjectTest("AAAA", 2));
            _staticQueue.Push(new ObjectTest("AAAA", 1));
            _staticQueue.Push(new ObjectTest("BBBB", 4));
            //Assert
            bool isOrdered = true;
            for (int i = 0; i < _staticQueue.Length - 1; i++)
            {
                isOrdered = _staticQueue[i].Id <= _staticQueue[i + 1].Id;
                if (!isOrdered)
                    break;
            }
            Assert.IsTrue(isOrdered);

        }

        [TestMethod, TestCategory("StaticQueue"), ExpectedException(typeof(NullObjectException))]
        public void Push_NullValue_NullObjectException()
        {
            //Arrange --Configurado no Initialize

            //Act
            _staticQueue.Push(null);
            //Assert
            Assert.Inconclusive("Uma exceção do tipo NullObjectException deveria ter acontecido!");

        }


        [TestMethod, TestCategory("StaticQueue")]
        public void Push_ObjectInFullCollectionResizable_LengthEqualsThree()
        {
            //Arrange
            _staticQueue = new StaticQueue<ObjectTest>(2, true, _comparisonObjectTest);
            _staticQueue.Push(new ObjectTest("AAAA", 1));
            _staticQueue.Push(new ObjectTest("BBBB", 2));
            //Act
            _staticQueue.Push(new ObjectTest("CCCC", 3));
            //Assert

            Assert.IsTrue(_staticQueue.Length == 3 && _staticQueue.MaxSize == 102);

        }

        public void Push_ObjectInFullCollectionNotResizable_Exception()
        {
            ////Arrange
            //_staticQueue = new StaticQueue<ObjectTest>(2, true, _comparisonObjectTest);
            //_staticQueue.Push(new ObjectTest("AAAA", 1));
            //_staticQueue.Push(new ObjectTest("BBBB", 1));
            ////Act
            //_staticQueue.Push()
            ////Assert

            //Assert.IsTrue(_staticQueue.Length)
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
