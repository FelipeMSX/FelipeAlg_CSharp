using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Algorithms._abstract;
using Algorithms.exception;

namespace Algorithms.collection
{

	/// <summary>
	/// -----------------------------------Descrição da fila---------------------------------
	/// -------------------------------------------------------------------------------------
	/// </summary>
	/// <typeparam name="E"></typeparam>
	class Queue<E> : Queue_Stack<E> where E : IComparable
	{
		/// <summary>
		/// Inserir o objeto de acordo com o indicador do currentSize,ou seja, a cada inserção a próxima ocorrerá no currentSize+1.
		/// Não é permitido valor nulo.
		/// </summary>
		/// <param name="obj"></param>
		public override void Insert(E obj)
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
		public override E Remove()
		{
			if (IsEmpty())
				throw new EmptyCollectionException();

			E temp = Vector[0];
			currentSize--;

			for (int i = 0; i < currentSize; i++)
				Vector[i] = Vector[i + 1];

			return temp;
		}

		/// <summary>
		/// Recupara o primeiro item a sair da fila.
		/// </summary>
		/// <returns></returns>
		public override E Retrive()
		{
			return FirstItem();
		}
	}
}
