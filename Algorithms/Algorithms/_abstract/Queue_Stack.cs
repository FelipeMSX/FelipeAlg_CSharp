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
		public bool canExtend;
		/// <summary>
		/// Propriedade que indica se a fila pode 
		/// </summary>
		public bool CanExtend { get; set; }

		public abstract void Insert(E obj);
		public abstract E Remove();
		public abstract E Retrive();
	}
}
