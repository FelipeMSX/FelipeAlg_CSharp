using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Algorithms._abstract;

namespace Algorithms.collection
{
	class Stack<E> : Queue_Stack<E> where E : IComparable
	{
		public override void Insert(E obj)
		{
			throw new NotImplementedException();
		}

		public override E Remove()
		{
			throw new NotImplementedException();
		}

		public override E Retrive()
		{
			throw new NotImplementedException();
		}
	}
}
