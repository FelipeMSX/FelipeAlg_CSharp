using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Algorithms._abstract;
using Algorithms.exception;

namespace Algorithms.collection
{

	/// <summary>
	/// </summary>
	/// <typeparam name="E"></typeparam>
	class Queue<E> : Queue_Stack<E> where E : IComparable
	{
		/// <summary>
		/// Inicializa com o valor padrão que é 100.
		/// </summary>
		public Queue(): base(){}

		public Queue(int initialSize): base(initialSize) {}

		/// <summary>
		/// Inserir o objeto de acordo com o indicador do currentSize,ou seja, a cada inserção a próxima ocorrerá no currentSize+1.
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

		/// <summary>
		/// Remove e retorna o primeiro item a sair da fila(vector[0]).
		/// </summary>
		/// <returns></returns>
		public override E Pop()
		{
			if (IsEmpty())
				throw new EmptyCollectionException();

			E temp = Vector[0];
			CurrentSize--;

			for (int i = 0; i < CurrentSize; i++)
				Vector[i] = Vector[i + 1];

			Vector[CurrentSize] = default(E);

			return temp;
		}

		public override E Find(E obj)
		{
			for (int i = 0; i < CurrentSize; i++)
			{
				if (Vector[i].CompareTo(obj) == 0)
					return Vector[i];
			}

			return default(E);
		}
	}
}
