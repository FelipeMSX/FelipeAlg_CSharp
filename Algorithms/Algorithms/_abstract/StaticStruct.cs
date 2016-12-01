using System;
using Algorithms._interface;
using Algorithms.exception;

namespace Algorithms._abstract
{
	/// <summary>
	/// Define uma classe abstrata para qualquer estrutura que precise de um vetor.
	/// Vetor pode ter sua capacidade aumentada caso necessário.
	/// </summary>
	/// <typeparam name="E">Tipo do objeto armazenado na coleção.</typeparam>
	public abstract class StaticStruct<E> : Common<E>, DefaultComparator<E>
	{
		/// <summary>
		/// Constante que define um valor inicial padrão para a coleção.
		/// </summary>
		public readonly int MAXSIZEDEFAULT = 100;

		/// <summary>
		/// Fornece um método de comparação para os objetos da coleção.
		/// </summary>
		public Comparison<E> Comparator { get; set; }

		/// <summary>
		/// Vetor que armazena os objetos genéricos da coleção.
		/// </summary>
		protected E[] Vector { get; set; }

		/// <summary>
		/// Obtém o tamanho atual da coleção.
		/// </summary>
		public int Length { get; protected set; }

		private int maxSize;

		/// <summary>
		/// Controla o crescimento da coleção, definindo um limite a ela.
		/// </summary>
		/// <exception cref="ValueNotValidException">Valor não pode ser menor que o atual.</exception>
		public int MaxSize
		{
			get { return maxSize; }
			set
			{
				if (value < maxSize)
					throw new ValueNotValidException("max size can't be less than current!");
				maxSize = value;
			}
		}

		/// <summary>
		/// Ao atingir o valor máximo de itens da coleção esse valor será utilizado para aumentar a capacidade da coleção. 
		/// </summary>
		public int ResizeValue { get; set; }

		/// <summary>
		/// Define se a coleção deve se expandir ao atingir a capacidade máxima.
		/// </summary>
		public bool Resizable { get; set; }

		public StaticStruct()
		{
			MaxSize		= MAXSIZEDEFAULT;
			ResizeValue = MAXSIZEDEFAULT;
			Vector		= new E[MaxSize];
			Resizable	= true;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="maxSize">Valor máximo de itens que a coleção pode armazenar.</param>
		/// <param name="resizable">Define se a coleção deve se expandir ao atingir a capacidade máxima.</param>
		/// <param name="comparator">Fornece um método de comparação para os objetos da coleção.</param>
		public StaticStruct(int maxSize, bool resizable = true, Comparison<E> comparator = null)
		{
			MaxSize		= maxSize;
			ResizeValue = MAXSIZEDEFAULT;
			Vector		= new E[MaxSize];
			Resizable	= resizable;
			Comparator	= comparator;
		}

		/// <summary>
		/// Remove todos os objetos da coleção.
		/// </summary>
		public void DisposeAll()
		{
			Vector = new E[MaxSize];
			Length = 0;
		}

		/// <summary>
		/// Informa se a coleção está vazia.
		/// </summary>
		public bool Empty() => Length == 0;

		/// <summary>
		/// Informa se a coleção está cheia.
		/// </summary>
		public bool Full() => Length == MaxSize;

		/// <summary>
		/// Retorna o primeiro elmento da coleção. Se estiver vazia retorna o valor default do tipo do objeto.
		/// </summary>
		public E First() => Empty() ? default(E) : Vector[0];

		/// <summary>
		/// Retorna o último elmento da coleção. Se estiver vazia retorna o valor default do tipo do objeto.
		/// </summary>
		public E Last() => Empty() ? default(E) : Vector[Length - 1];

		/// <summary>
		/// Percorre a coleção até encontrar o objeto. Somente retorna o objeto não o remove.
		/// </summary>
		/// <exception cref="EmptyCollectionException">Caso a coleção esteja vazia. </exception>
		/// <exception cref="ComparerNotSetException">Caso a coleção não tenha um comparator definido.</exception>
		/// <param name="obj">Objeto com as keys necessárias para encontrar um objeto na coleção.</param>
		/// <returns></returns>
		public E Retrive(E obj)
		{
			if (Empty())
				throw new EmptyCollectionException();
			if (Comparator == null)
				throw new ComparerNotSetException();

			for (int i = 0; i < Length; i++)
			{
				if (Comparator(Vector[i], obj) == 0)
					return obj;
			}
			return default(E);
		}

		/// <summary>
		/// Aumenta a capacidade da coleção de acordo com o ResizeValue.
		/// </summary>
		/// <exception cref="FullCollectionException">A coleção não pode aumentar sua capacidade</exception>
		protected void IncreaseCapacity()
		{
			if (!Resizable)
				throw new FullCollectionException();

			MaxSize += ResizeValue;
			E[] temp = new E[MaxSize];

			for (int i = 0; i < Length; i++)
			{
				temp[i] = Vector[i];
			}
			Vector = temp;
		}
	}
}
