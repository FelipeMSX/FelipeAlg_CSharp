using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Algorithms._interface;
using Algorithms.exception;

namespace Algorithms._abstract
{
	abstract class StaticStruct<E> : ICommon<E>
	{
		protected E[] Vector;

		protected int currentSize;
		protected int CurrentSize { get; set; }

		protected int maxSize;
		protected int MaxSize { get; set; }

		public E FirstItem()
		{
			if (ISEmpty())
				throw new EmptyCollectionException("A coleção de itens está vazia!");
			else
				return Vector[0];
		}

		public bool ISEmpty()
		{
			throw new NotImplementedException();
		}

		public bool IsFull()
		{
			throw new NotImplementedException();
		}

		public E LastItem()
		{
			throw new NotImplementedException();
		}

		public int Size()
		{
			throw new NotImplementedException();
		}
	}
}
