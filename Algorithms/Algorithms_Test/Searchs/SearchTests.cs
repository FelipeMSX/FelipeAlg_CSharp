using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms;
using Algorithms.Searchs;
using System.Collections;
using Algorithms.Nodes;

namespace AlgorithmsTests.search
{
	[TestClass]
	public class SearchTests
	{
        /*Técnica utilizada para geração dos testes: Caixa Preta - Particionamento de equivalência.
         * 
         * 
         * 
         * 
         * 
         * 
         */
 
		[TestMethod]
		[TestCategory("Search")]
		
		public void TestBinarySearch()
		{
 
			LinkedDoubleNode<String> n = new LinkedDoubleNode<string>();
			//Definindo o delegate com lambda expression.
			Search<int> s = new Search<int>((x, y) => x.CompareTo(y));
			

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
