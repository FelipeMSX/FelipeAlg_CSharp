using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms.sort;

namespace AlgorithmsTests.Sorts
{
	[TestClass]
	public class MergeSort
	{
		private string[] vector;
		[TestInitialize]
		public void Initialize()
		{
			vector = new String[] { "100","40","20","30","4","500","20","25","25" };
		}

		[TestMethod]
		[TestCategory("MergeSort")]
		public void TestMergeSort()
		{		
			MergeSort<String> merge = new MergeSort<string>((x,y) => x.CompareTo(y));
		}
	}
}
