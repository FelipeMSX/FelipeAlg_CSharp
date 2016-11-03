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
	public abstract class LinkedStruct<E, T> : Common<E> 
		where T: LinkedNode<E> 
		where T: LinkedDoubleNode<E>
	{

		public LinkedStruct()
		{
			Head = default(T);
		}

		public abstract void Insert(E obj);
		public abstract E Remove(E obj);

		protected Comparison<E> Comparator { get; set; }
		protected T Head { get; set; }

		public int Length { get; protected set; }

		public void DisposeAll()
		{
			Head.Next	= default(T);
			Length		= 0;
		}

		public bool Empty()
		{
			return Length == 0;
		}

		public E First()
		{
			if (Empty())
			{
				throw new EmptyCollectionException();
			}
			else
			{
				return Head.Next.Value;
			}
		}

		public E Last()
		{
			if (Empty())
			{
				throw new EmptyCollectionException();
			}
			else
			{
				LinkedNode<E> current = Head.Next;
				while (current.HasNext())
				{
					current = current.Next;
				}
				return current.Value;
			}
		}

		public E Retrive(E obj)
		{
			if (Empty())
			{
				throw new EmptyCollectionException();
			}
			else
			{
				LinkedNode<E> current = Head.Next;
				while (current != null && obj.Equals(current.Value))
				{
					current = current.Next;
				}
				return current.Value;
			}
		}

		public IEnumerator<E> Iterator()
		{
			LinkedNode<E> current = Head.Next;
			while(current != null)
			{
				yield return current.Value;
				current = current.Next;
			}
		}
	}
}
