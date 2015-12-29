using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Algorithms._interface;
using Algorithms.exception;

namespace Algorithms._abstract
{
	internal abstract class Queue_Stack<E> : StaticStruct<E>
	{
		public Queue_Stack():base(){}

		public Queue_Stack(int initialSize):base(initialSize){}

		public abstract void Push(E obj);
		public abstract E Pop();
	}
}
