using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Algorithms._interface;
using Algorithms.exception;

namespace Algorithms._abstract
{
	internal abstract class StaticStruct<E> : ICommon<E>
	{
		protected E[] vector;
		protected E[] Vector { get; set; }

		protected int currentSize;
		protected int CurrentSize { get; set; }

		protected int maxSize;
		protected int MaxSize { get; set; }


		#region métodos da interface
		public bool ISEmpty()
		{
			return CurrentSize == 0;
		}

		public bool IsFull()
		{
			return currentSize == MaxSize;
		}

		public E FirstItem()
		{
			if (ISEmpty())
				throw new EmptyCollectionException("A coleção de itens está vazia!");
			else
				return Vector[0];
		}

		public E LastItem()
		{
			if (ISEmpty())
				throw new EmptyCollectionException("A coleção de itens está vazia!");
			else
				return Vector[currentSize - 1];
		}

		public int Size()
		{
			return CurrentSize;
		}
		#endregion
	}
}
