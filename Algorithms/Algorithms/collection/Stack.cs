using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Algorithms._abstract;
using Algorithms.exception;

namespace Algorithms.collection
{
	class Stack<E> : Queue_Stack<E> where E : IComparable
	{
		/// <summary>
		/// Inicializa com o valor padrão que é 100.
		/// </summary>
		public Stack(): base(){ }

		public Stack(int initialSize): base(initialSize) { }


		/// <summary>
		/// Coloca o objeto na pilha.
		/// Não é permitido valor nulo.
		/// </summary>
		/// <param name="obj"></param>
		public override void Push(E obj)
		{
			if (obj == null)
				throw new NullObjectException();

			if (IsFull())
			{
				if (CanExtend)
					DoubleCapacity();
				else
					throw new FullCollectionException();
			}
			else
			{
				Vector[currentSize++] = obj;
			}
		}

		public override E Pop()
		{
			if (IsEmpty())
				throw new EmptyCollectionException();

			E temp = Vector[--CurrentSize];
			Vector[CurrentSize] = default(E);
			return temp;
		}


		/// <summary>
		/// Recupera o primeiro objeto da pilha sem removê-lo.
		/// </summary>
		/// <returns></returns>
		public override E FirstItem()
		{
			if (IsEmpty())
				throw new EmptyCollectionException();
			else
				return Vector[CurrentSize-1];
		}


		/// <summary>
		/// Recupera o último objeto da pilha sem removê-lo.
		/// </summary>
		/// <returns></returns>
		public override E LastItem()
		{
			if (IsEmpty())
				throw new EmptyCollectionException();
			else
				return Vector[0];
		}
	}
}
