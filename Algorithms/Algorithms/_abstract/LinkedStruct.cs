using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.node;
using Algorithms.exception;
using Algorithms._interface;
using System.Collections.Generic;
using System.Collections;

namespace Algorithms._abstract
{
	class LinkedStruct<E, T> : Common<E> where T: LinkedNode<E>, new()
	{

		public LinkedStruct()
		{ 
			Head =  new T();
		}

		private Comparison<E> comparator;
		protected Comparison<E> Comparator
		{
			get { return comparator; }
			set
			{
				if (value == null)
					throw new ComparerNotSetException();
				comparator = value;
			}
		}
		protected T Head { get; set; }

		public int Length { get; protected set; }

		private int maxSize;
		public int MaxSize
		{
			get { return maxSize; }
			set
			{
				if (value < maxSize)
					throw new ValueNotValidException("max size can't be less than current!");
				maxSize = value;
			}
		}

		public void DisposeAll()
		{
			throw new NotImplementedException();
		}

		public bool Empty()
		{
			throw new NotImplementedException();
		}

		public E First()
		{
			throw new NotImplementedException();
		}

		public E Last()
		{
			throw new NotImplementedException();
		}

		public E Retrive(E obj)
		{
			throw new NotImplementedException();
		}

		public IEnumerator Iterator()
		{
			LinkedNode<E> current = Head.Next;
			while(current != null)
			{
				yield return current;
				current = current.Next;
			}
		}
	}
}
