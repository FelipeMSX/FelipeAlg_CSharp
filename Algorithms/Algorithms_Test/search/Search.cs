using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms;
using Algorithms.search;
using System.Collections;

namespace Algorithms_Test.search
{
	[TestClass]
	public class TSearch
	{
 
		/// <summary>
		/// 
		/// </summary>
		[TestMethod]
		[TestCategory("Search")]
		
		public void TestBinarySearch()
		{
 
			//Definindo o delegate com lambda expression.
			Search<int> s = new Search<int>((x, y) => 
			{
				if (x > y)
					return 1;
				else
				if (x < y)
					return -1;
				else
					return 0;
			}
			);

			int[] numbers = new int[] { 1, 2, 3, 4, 5 };

			//Testando para um objeto que existe no limite esquerdo.
			{
				int result = s.BinarySearch(numbers, 1);
				Assert.IsTrue(result == 1,"É esperado encontrar o objeto 1");
			}

			//Testandop para um objeto no limite direito.
			{
				int result = s.BinarySearch(numbers, 5);
				Assert.IsTrue(result == 5, "É esperado encontrar o objeto 5");
			}

			//Testando para um objeto que não está presente na lista.
			{
				int result = s.BinarySearch(numbers, 15);
				Assert.IsTrue(result == default(int), "É esperado encontrar o objeto");
			}

		}
	}
}
