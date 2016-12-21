using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms._struct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.exception;
using Algorithms_Test;

namespace Algorithms._struct.Tests
{
	[TestClass()]
	
	public class LinkedList
	{
		private LinkedList<String> list;
		private LinkedList<String> emptyList;

		[TestInitialize]
		public void Initialize()
		{
			list = new LinkedList<string>();
			emptyList = new LinkedList<string>();
			list.Comparator = (x, y) => x.CompareTo(y);
			list.Insert(ObjectTest.Objects[0]);
			list.Insert(ObjectTest.Objects[1]);
			list.Insert(ObjectTest.Objects[2]);
			list.Insert(ObjectTest.Objects[3]);
		}

		[TestMethod]
		[TestCategory("LinkedList")]
		public void InsertLinkedList()
		{
			list.Remove(ObjectTest.Objects[0]);
			list.Insert(ObjectTest.Objects[0]);
			Assert.IsTrue(list.Length == 4);

			list.Remove(ObjectTest.Objects[0]);
			list.Remove(ObjectTest.Objects[1]);
			list.Remove(ObjectTest.Objects[2]);
			list.Remove(ObjectTest.Objects[3]);

			Assert.IsTrue(list.Length == 0);
		}

		[TestMethod]
		[TestCategory("LinkedList")]
		public void RemoveLinkedList()
		{
			Object obj = list.Remove(ObjectTest.Objects[0]);
			Assert.AreEqual(obj, ObjectTest.Objects[0]);
			Assert.IsTrue(list.Length == 3);
		}

		[TestMethod]
		[TestCategory("LinkedList")]
		[ExpectedException(typeof(EmptyCollectionException))]
		public void RemoveLinkedListEmpty()
		{
			emptyList.Remove("AAAAA");
		}

		[TestMethod]
		[TestCategory("LinkedList")]
		[ExpectedException(typeof(NullObjectException))]
		public void RemoveLinkedListNullObject()
		{
			emptyList.Remove(null);
		}

		[TestMethod]
		[TestCategory("LinkedList")]
		[ExpectedException(typeof(ComparerNotSetException))]
		public void RemoveLinkedListNullComparator()
		{
			list.Comparator = null;
			list.Remove(ObjectTest.Objects[0]);
		}

		[TestMethod]
		[TestCategory("LinkedList")]
		[ExpectedException(typeof(ElementNotFoundException))]
		public void RemoveLinkedListElementNotFound()
		{
			list.Remove("NotExists");
		}

		[TestMethod]
		[TestCategory("LinkedList")]
		public void FirstLinkedList()
		{
			Assert.IsTrue(list.First() == ObjectTest.Objects[0]) ;
		}

		[TestMethod]
		[TestCategory("LinkedList")]
		[ExpectedException(typeof(EmptyCollectionException))]
		public void FirstLinkedListEmpty()
		{
			emptyList.First();
		}

		[TestMethod()]
		[TestCategory("LinkedList")]
		public void LastLinkedList()
		{
			Assert.IsTrue(list.Last() == ObjectTest.Objects[3]);
		}

		[TestMethod()]
		[TestCategory("LinkedList")]
		[ExpectedException(typeof(EmptyCollectionException))]
		public void LastLinkedListEmpty()
		{
			emptyList.Last();
		}

		[TestMethod()]
		public void RetriveLinkedList()
		{
			Assert.IsTrue(list.Retrive(ObjectTest.Objects[0]) == ObjectTest.Objects[0],"Deve ser capaz de encontrar o objeto.");
		}

		[TestMethod()]
		public void RetriveLinkedListEmpty()
		{
			emptyList.Retrive(ObjectTest.Objects[0]);
		}
		[TestMethod()]
		public void RetriveLinkedListNullObject()
		{
			throw new NotImplementedException();
		}
		[TestMethod()]
		public void RetriveLinkedListNullComparator()
		{
			throw new NotImplementedException();
		}


		[TestMethod()]
		public void GetEnumeratorLinkedList()
		{
			int i = 0;
			foreach(String s in list)
			{
				Assert.AreEqual(s, ObjectTest.Objects[i++]);
			}
		}
	}
}