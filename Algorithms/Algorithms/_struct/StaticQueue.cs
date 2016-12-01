using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms._abstract;
using Algorithms.exception;

namespace Algorithms._struck
{
	public class StaticQueue<E> : Queue_Stack<E>
	{

		public StaticQueue() : base(MAXSIZEDEFAULT)
		{
		}

		public StaticQueue(int maxsize, bool resizable = true, Comparison<E> comparator = null) : base (maxsize, resizable, comparator)
		{
		}
		public override E Pop()
		{
			if (Empty())
				throw new EmptyCollectionException();

			E obj = Vector[0];
			for (int i = 0; i < Length; i++)
			{
				Vector[i] = Vector[i + 1];
			}

			Length--;
			return obj;

		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="obj"></param>
		public override void Push(E obj)
		{
			if (obj == null)
				throw new NullObjectException();
			if (Full() && !Resizable)
				throw new FullCollectionException();

			DoubleCapacity();
			Vector[MaxSize++] = obj;
		}
	}
}
