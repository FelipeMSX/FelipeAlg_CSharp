using System;
using Algorithms.Collections;
using Algorithms.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms_Test.Collections
{
    [TestClass]
    public class BinaryTreeTest
    {
        private BinaryTree<int?> _binaryTree;

        private bool IsCrescentOrder()
        {
            bool hasOrdered = true;
            int? previousItem = -100;
            foreach (int? item in _binaryTree)
            {
                if (previousItem > item)
                {
                    hasOrdered = false;
                    break;
                }
                previousItem = item;
            }

            return hasOrdered;
        }

        [TestInitialize]
        public void SetUp()
        {
            _binaryTree = new BinaryTree<int?>(Shared.DefaultIntComparison);
        }

        [TestCleanup]
        public void teste()
        {
            _binaryTree = null;
        }


        /// <summary>
        /// Técnica: Caminho e Decisão.
        /// </summary>
        [TestMethod, TestCategory("BinaryTree"), ExpectedException(typeof(NullObjectException))]
        public void Insert_WhenObjectIsNull_Exception()
        {
            //Arrange
            //Act
            _binaryTree.Insert(null);
            //Assert
            Assert.Inconclusive("An exception is expected!");
        }

        /// <summary>
        /// Técnica: Caminho e Decisão.
        /// </summary>
        [TestMethod, TestCategory("BinaryTree")]
        public void Insert_PuttingOneObject_OneObjectInserted()
        {
            //Arrange
            //Act
            _binaryTree.Insert(10);
            //Assert
            Assert.IsTrue(_binaryTree.Length == 1,"The lenght of the binary tree should be 1!");
        }

        /// <summary>
        /// Técnica: Caminho e Decisão.
        /// </summary>
        [TestMethod, TestCategory("BinaryTree")]
        public void Insert_RootAndLeft_Success()
        {
            //Arrange
            //Act
            _binaryTree.Insert(10);
            _binaryTree.Insert(1);
            //Assert
            Assert.IsTrue(_binaryTree.Length == 2, "The lenght of the binary tree should be 2!");
        }

        /// <summary>
        /// Técnica: Caminho e Decisão.
        /// </summary>
        [TestMethod, TestCategory("BinaryTree")]
        public void Insert_RootAndLeftAndRight_Success()
        {
            //Arrange
            //Act
            _binaryTree.Insert(10);
            _binaryTree.Insert(1);
            _binaryTree.Insert(15);
            //Assert
            Assert.IsTrue(_binaryTree.Length == 3, "The lenght of the binary tree should be 3!");
        }

        /// <summary>
        /// Técnica: Caminho e Decisão.
        /// </summary>
        [TestMethod, TestCategory("BinaryTree")]
        public void Insert_RootAndLeftAndLeftAndRight_Success()
        {
            //Arrange
            //Act
            _binaryTree.Insert(10);
            _binaryTree.Insert(1);
            _binaryTree.Insert(0);
            _binaryTree.Insert(15);
            //Assert
            Assert.IsTrue(_binaryTree.Length == 4, "The lenght of the binary tree should be 4!");
        }

        /// <summary>
        /// Técnica: Caminho e Decisão.
        /// </summary>
        [TestMethod, TestCategory("BinaryTree")]
        public void Insert_RootAndRightAndRightAndRight_Success()
        {
            //Arrange
            //Act
            _binaryTree.Insert(10);
            _binaryTree.Insert(100);
            _binaryTree.Insert(200);
            _binaryTree.Insert(300);
            //Assert
            Assert.IsTrue(_binaryTree.Length == 4, "The lenght of the binary tree should be 4!");
        }

        /// <summary>
        /// Técnica: Caminho e Decisão.
        /// </summary>
        [TestMethod, TestCategory("BinaryTree"), ExpectedException(typeof(EqualsElementException))]
        public void Insert_EqualsElements_Fail()
        {
            //Arrange
            //Act
            _binaryTree.Insert(10);
            _binaryTree.Insert(10);
            //Assert
            Assert.Inconclusive("An exeption was expected!");
        }


        /// <summary>
        /// Técnica: Caminho e Decisão.
        /// </summary>
        [TestMethod, TestCategory("BinaryTree"), ExpectedException(typeof(NullObjectException))]
        public void Retrieve_NullValue_Exception()
        {
            //Arrange
            //Act
            _binaryTree.Insert(10);
            _binaryTree.Insert(1);
            _binaryTree.Retrieve(null);
            //Assert
            Assert.Inconclusive("An exception was expected!");
        }
        /// <summary>
        /// Técnica: Caminho e Decisão.
        /// </summary>
        [TestMethod, TestCategory("BinaryTree"), ExpectedException(typeof(EmptyCollectionException))]
        public void Retrieve_TryingRetriveInEmptyCollection_Exception()
        {
            //Arrange
            //Act
            _binaryTree.Retrieve(1);
            //Assert
            Assert.Inconclusive("An exception was expected!");
        }

        /// <summary>
        /// Técnica: Caminho e Decisão.
        /// </summary>
        [TestMethod, TestCategory("BinaryTree")]
        public void Retrieve_RootAndLeft_LeftObjectReturned()
        {
            //Arrange
            //Act
            _binaryTree.Insert(10);
            _binaryTree.Insert(1);
            int? result = _binaryTree.Retrieve(1);
            //Assert
            Assert.IsTrue(result == 1, "The binary tree should be returned the element 1!");
        }


        /// <summary>
        /// Técnica: Caminho e Decisão.
        /// </summary>
        [TestMethod, TestCategory("BinaryTree"), ExpectedException(typeof(ElementNotFoundException))]
        public void Retrieve_TryingRetriveAnNonExistentElement_Exception()
        {
            //Arrange
            //Act
            _binaryTree.Insert(10);
            _binaryTree.Insert(1);
            int? result = _binaryTree.Retrieve(200);
            //Assert
            Assert.Inconclusive("An exception was expected!");
        }

        /// <summary>
        /// Técnica: Caminho e Decisão.
        /// </summary>
        [TestMethod, TestCategory("BinaryTree")]
        public void GetEnumerator_RootAndRightAndRightAndRight_CrescentOrder()
        {
            //Arrange
            //Act
            _binaryTree.Insert(10);
            _binaryTree.Insert(100);
            _binaryTree.Insert(200);
            _binaryTree.Insert(300);
            //Assert
            Assert.IsTrue(IsCrescentOrder(), "The binary tree should be in crescent order!");
        }

        /// <summary>
        /// Técnica: Caminho e Decisão.
        /// </summary>
        [TestMethod, TestCategory("BinaryTree")]
        public void GetEnumerator_RootAndLeftAndLeftAndRight_CrescentOrder()
        {
            //Arrange
            //Act
            _binaryTree.Insert(10);
            _binaryTree.Insert(5);
            _binaryTree.Insert(1);
            _binaryTree.Insert(300);
            //Assert
            Assert.IsTrue(IsCrescentOrder(), "The binary tree should be in crescent order!");
        }
    }
}
