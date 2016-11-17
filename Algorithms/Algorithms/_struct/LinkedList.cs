using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms._abstract;
using Algorithms.exception;
using Algorithms.node;

namespace Algorithms._struct
{
	public class LinkedList<E> : LinkedStruct<E, LinkedNode<E>>
	{

		public LinkedList() : base()
		{
			Head = new LinkedNode<E>();
		}

		public override void Insert(E obj)
		{
			if (obj == null)
				throw new NullObjectException();

			LinkedNode<E> newNode;
			newNode = new LinkedNode<E>(obj);
			if (Empty())
			{
				Head.Next = newNode;
			}
			else
			{
				LinkedNode<E> searchNode = Head.Next;

				while (searchNode.HasNext())
					searchNode = searchNode.Next;
				
				searchNode.Next = newNode;		
			}
			Length++;
		}

		public override E Remove(E obj)
		{
			if (obj == null)
				throw new NullObjectException();
			else
			if (Empty())
			{
				throw new EmptyCollectionException();
			}
			else
			{
				if (Comparator == null)
					throw new ComparerNotSetException();

				//Caso a coleção contenha somente um elemento.
				if (Comparator(Head.Next.Value, obj) == 0)
				{
					LinkedNode<E> temp = Head.Next;
					Head.Next = temp.Next;
					Length--;
					return temp.Value;
					//Caso quando a coleção possui vários elementos e é preciso procurar o elemento.
				}
				else
				{
					LinkedNode<E> search = Head.Next;
					LinkedNode<E> previous = Head.Next;

					while (previous.HasNext())
					{
						if (Comparator(search.Value, obj) == 0)
						{
							previous.Next = search.Next;
							search.Next = null;
							Length--;
							return search.Value;
						}
						previous = search;
						search = search.Next;
					}
					throw new ElementNotFoundException();
				}
			}
		}

		public override E First()
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

		public override E Last()
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

		public override E Retrive(E obj)
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

		public override IEnumerator<E> GetEnumerator()
		{
			LinkedNode<E> current = Head.Next;
			while (current != null)
			{
				yield return current.Value;
				current = current.Next;
			}
		}
	}
}
