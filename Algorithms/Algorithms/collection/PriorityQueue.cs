using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Algorithms._abstract;
using Algorithms.exception;
using Algorithms.search;

namespace Algorithms.collection
{
	/// <summary>
	/// O primeiro elemento a sair é sempre no início do vetor[0].
	/// Elemento com key igual é colocado sempre atrás dos outros elementos com a mesma key.
	/// </summary>
	/// <typeparam name="E"></typeparam>
	class PriorityQueue<E> : Queue<E> where E : IComparable
	{
		/// <summary>
		/// Inicializa com o valor padrão que é 100.
		/// </summary>
		public PriorityQueue(): base(){}

		public PriorityQueue(int initialSize): base(initialSize) {}

		/// <summary>
		/// 
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
				int position = 0;
				while (position < CurrentSize && obj.CompareTo(Vector[position]) <= 0)
					position++;
				for (int i = CurrentSize; i > position; i--)
				{
					Vector[i] = Vector[i - 1];
				}
				Vector[position] = obj;
				CurrentSize++;
			}
		}


		/// <summary>
		/// Utiliza busca binária para encontrar o item.
		/// </summary>
		/// <param name="key"></param>
		/// <returns></returns>
		public override E Find(E key)
		{
			return Search<E>.BinarySearch(Vector, key);
		}

	}
}
