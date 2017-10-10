using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms.Sorts;

namespace AlgorithmsTests.Sorts
{
	[TestClass]
	public class MergeSortTests
	{
		private string[] vector;
		[TestInitialize]
		public void Initialize()
		{
			vector = new String[] { "100","40","20","30","4","500","20","25","25" };
		}

		[TestMethod]
		[TestCategory("MergeSort")]
		public void Sort_StringList_CrescenteOrderedList()
		{		
            //Arrange
			MergeSort<String> merge = new MergeSort<string>((x,y) => x.CompareTo(y));

            //Act
            merge.Sort(vector);

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
