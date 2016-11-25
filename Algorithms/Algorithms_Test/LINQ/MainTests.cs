using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms.LINQ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms._struct;

namespace Algorithms.LINQ.Tests
{
	[TestClass()]
	public class MainTests
	{
		LinkedListLINK<String> list;
		public void testeTest()
		{
		}

		[TestInitialize]
		public void Initialize()
		{
			list = new LinkedListLINK<String>();
			list.Insert("AAA");
			list.Insert("BBB");
			list.Insert("CCC");
			list.Insert("DDD");
			list.Insert("111");
			list.Insert("222");
			list.Insert("333");
			list.Insert("ACB");
			list.Insert("123");
			list.Insert("340");
		}

		[TestMethod]
		[TestCategory("LINQ")]
		public void LINKInsertLinkedList()
		{
			int temp = 0;
			List<String> lk = list.Filtrar(x => Int32.TryParse(x, out temp));

			List<String> lk2 = list.Selecionar<String, String>(x => x + "!!!");
			Console.WriteLine("Wololô");

		}

	}
}