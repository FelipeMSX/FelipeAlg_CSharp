using Algorithms.Sorts;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AlgorithmsTests.Sorts
{
    [TestClass]
	public class QuickSortTests
	{
        private string[] vector;
        private int[] vectorInteger;
        [TestInitialize]
        public void Initialize()
        {
            vector = new String[] { "100", "40", "20", "30", "4", "500", "20", "25", "25" };
            vectorInteger = new int[] { 100, 40, 20, 30, 4, 500, 20, 25, 25 };
        }

        [TestMethod]
        [TestCategory("QuickSort")]
        public void Sort_StringList_CrescenteOrderedList()
        {
            //Arrange
            QuickSort<int> quickSort = new QuickSort<int>((x, y) => x.CompareTo(y));

            //Act
            quickSort.Sort(vectorInteger);

            //Assert
            bool isOrdered = true;
            for (int i = 0; i < vector.Length - 1; i++)
            {
                isOrdered = vector[i].CompareTo(vector[i + 1]) <= 0;
                if (!isOrdered)
                    break;
            }
        }
    }
}
