using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms.Collections;
using AlgorithmsTests;
using Algorithms.Exceptions;
using NSubstitute;

namespace Algorithms_Test.Collections
{
    [TestClass]
    public class StaticPriorityQueueTests
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
            _staticQueue = new StaticQueue<ObjectTest>(100, true, _comparisonObjectTest);
        }

        [TestMethod, TestCategory("StaticPriorityQueue")]
        public void Push_ThreeObjects_LengthEqualsThree()
        {
            //Arrange --Configurado no Initialize
            //Act
            _staticQueue.Push(new ObjectTest("AAAA", 2));
            _staticQueue.Push(new ObjectTest("AAAA", 1));
            _staticQueue.Push(new ObjectTest("BBBB", 4));
            //Assert
            Assert.IsTrue(_staticQueue.Length == 3);
        }

        #region WhiteBoxTests
        /// <summary>
        /// Técnica utilizada: Teste de Caminho e Decisão.
        /// </summary>
        [TestMethod, TestCategory("StaticPriorityQueue"), ExpectedException(typeof(NullObjectException))]
        public void Push_NullValue_NullObjectException()
        {
            //Arrange --Configurado no Initialize
            //Act
            _staticQueue.Push(null);
            //Assert
            Assert.Inconclusive("Uma exceção do tipo NullObjectException deveria ter acontecido!");
        }


        /// <summary>
        /// Técnica utilizada: Teste de Caminho e Decisão.
        /// </summary>
        [TestMethod, TestCategory("StaticPriorityQueue"), ExpectedException(typeof(NullObjectException))]
        public void Push_ComparerNotSet_ComparerNotSetException()
        {
            StaticPriorityQueue<ObjectTest> staticPriorityQueue =  Substitute.For<StaticPriorityQueue<ObjectTest>>();

  
            //Arrange --Configurado no Initialize
            //Act
            _staticQueue.Push(null);
            //Assert
            Assert.Inconclusive("Uma exceção do tipo NullObjectException deveria ter acontecido!");
        }

        #endregion


    }
}
