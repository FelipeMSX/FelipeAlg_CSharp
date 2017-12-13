using System;

namespace Algorithms.Abstacts
{
	/// <summary>
	/// Classe abstrata utilizada na criação de qualquer coleção que utilize uma pilha ou fila.
	/// </summary>
	/// <author>Felipe Morais</author>
	/// <email>felipemsx18@gmail.com</email>
	/// <typeparam name="E">Tipo do objeto armazenado na coleção.</typeparam>
	public abstract class QueueStackBase<E> : ArrayBase<E>
	{

		public abstract void Push(E obj);
		public abstract E Pop();

		protected QueueStackBase() : base()
		{
		}

        protected QueueStackBase(int maxsize, bool resizable = true, Comparison<E> comparator = null) : base (maxsize, resizable, comparator)
		{
		}
	}
}
