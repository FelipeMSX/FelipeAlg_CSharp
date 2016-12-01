using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms._abstract
{
	public abstract class Queue_Stack<E> : StaticStruct<E>
	{
		/// <summary>
		/// teste
		/// </summary>
		/// <param name="obj"></param>
		public abstract void Push(E obj);
		public abstract E Pop();

		public Queue_Stack() : base()
		{
		}

		public Queue_Stack(int maxsize, bool resizable = true, Comparison<E> comparator = null) : base (maxsize, resizable, comparator)
		{
		}
	}
}
