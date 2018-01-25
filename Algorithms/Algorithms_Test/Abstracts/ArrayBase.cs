using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmsTests;
using Algorithms.Abstacts;
using Algorithms.Collections;

namespace Algorithms_Test.Abstracts
{
    [TestClass]
    public class ArrayBase
    {
        private ArrayBase<ObjectTest> _arrayBase;

        //[TestInitialize]
        //public void Initialize()
        //{
        // }

        
        [TestMethod, TestCategory("StaticQueue")]
        public void Push_ThreeObjects_LengthEqualsThree()
        {
            //Arrange --Configurado no Initialize
            _arrayBase = new StaticQueue<ObjectTest>(100, true,true, ObjectTest.DefaultComparison);

            //Act
            //_staticQueue.Push(new ObjectTest("AAAA", 2));
            //_staticQueue.Push(new ObjectTest("AAAA", 1));
            //_staticQueue.Push(new ObjectTest("BBBB", 4));
            ////Assert
            //Assert.IsTrue(_staticQueue.Length == 3);
        }
    }
}
