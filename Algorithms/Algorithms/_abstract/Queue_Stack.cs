using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms._abstract
{
	abstract class Queue_Stack<E> : StaticStruct<E> where E: new()
	{
		public abstract void Push(E obj);
		public abstract E Pop();

		public Queue_Stack(int maxsize) : base(maxsize)
		{
		}

		public Queue_Stack(int maxsize, bool resizable) : base(maxsize, resizable)
		{
		}

		public Queue_Stack(int maxsize, Comparison<E> comparator) : base (maxsize, comparator)
		{
		}

		public Queue_Stack(int maxsize, bool resizable, Comparison<E> comparator) : base (maxsize, resizable, comparator)
		{
		}
	}
}
