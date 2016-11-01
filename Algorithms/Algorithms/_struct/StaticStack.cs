using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms._abstract;
using Algorithms.exception;

namespace Algorithms._struct
{
	class StaticStack<E> : Queue_Stack<E> where E: new()
	{
		public StaticStack() : base(MAXSIZEDEFAULT)
		{
		}

		public StaticStack(int maxSize): base(maxSize)
		{
		}

		public StaticStack(int maxsize, bool resizable) : base(maxsize, resizable)
		{
		}

		public StaticStack(int maxSize, Comparison<E> comparator) : base(maxSize ,comparator)
		{
		}

		public StaticStack(int maxsize, bool resizable, Comparison<E> comparator) : base (maxsize, resizable, comparator)
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
				E temp = Vector[--Length];
				Vector[Length] = default(E);

				return temp;
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
						Vector[Length++] = obj;
					}
					else
					{
						throw new FullCollectionException();
					}
				}
			}
		}
	}
}
