using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms._abstract;
using Algorithms.exception;

namespace Algorithms._struck
{
	class StaticQueue<E> : Queue_Stack<E> where E : new()
	{

		public StaticQueue() : base(MAXSIZEDEFAULT)
		{
		}

		public StaticQueue(int maxSize): base(maxSize)
		{
		}

		public StaticQueue(int maxsize, bool resizable) : base(maxsize, resizable)
		{
		}

		public StaticQueue(int maxSize, Comparison<E> comparator) : base(maxSize ,comparator)
		{ 
		}

		public StaticQueue(int maxsize, bool resizable, Comparison<E> comparator) : base (maxsize, resizable, comparator)
		{
		}
		public override E Pop()
		{
			if (Empty())
			{
				throw new EmptyCollectionException();
			}
			else
			{
				E obj = Vector[0];
				for (int i = 0; i < Length; i++)
				{
					Vector[i] = Vector[i + 1];
				}

				Length--;
				return obj;
			}
		}

		public override void Push(E obj)
		{
			if(obj == null)
			{
				throw new NullObjectException();
			}else
			{
				if (Full())
				{
					if (Resizable)
					{
						DoubleCapacity();
						Vector[MaxSize++] = obj;
					}else
					{
						throw new FullCollectionException();
					}
				}
			}
		}
	}
}
