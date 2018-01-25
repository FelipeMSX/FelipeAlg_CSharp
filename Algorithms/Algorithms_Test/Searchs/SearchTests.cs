using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms;
using Algorithms.Searchs;
using System.Collections;
using Algorithms.Nodes;
using Algorithms.Interfaces;
using Algorithms.Exceptions;
using System.Collections.Generic;

namespace AlgorithmsTests.search
{
	[TestClass]
	public class SearchTests
	{

        private ISearch search;

        [TestInitialize]
        public void SetUp()
        {
            search = new Search();
        }
        #region WhiteboxTests

        /// <summary>
        /// Técnica: Caminho de Decisão 
        /// </summary>
        [TestMethod, TestCategory("Search"), ExpectedException(typeof(ComparerNotSetException))]
        public void BinarySearch_ComparerIsNull_Exception()
        {
            //Arrange - feito no SetUp
            List<int> list = new List<int>();
            //Act
            search.BinarySearch(list, 1, null);
            //Assert
            Assert.Inconclusive("An exception was expected!");
        }

        /// <summary>
        /// Técnica: Caminho de Decisão 
        /// </summary>
        [TestMethod, TestCategory("Search"), ExpectedException(typeof(ComparerNotSetException))]
        public void BinarySearch_ListIsNull_Exception()
        {
            //Arrange - feito no SetUp
            List<ObjectTest> list = new List<ObjectTest>();
            ObjectTest objectTest = new ObjectTest();
            //Act
            search.BinarySearch(null, objectTest, ObjectTest.DefaultComparison);
            //Assert
            Assert.Inconclusive("An exception was expected!");
        }
        #endregion

    }
}
