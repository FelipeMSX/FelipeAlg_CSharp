﻿using System;
using Algorithms.Interfaces;
using Algorithms.Exceptions;

namespace Algorithms.Abstacts
{
	/// <summary>
	/// Define uma classe abstrata para qualquer estrutura que precise de um vetor.
	/// Vetor pode ter sua capacidade aumentada caso necessário.
	/// </summary>
	/// <author>Felipe Morais</author>
	/// <email>felipemsx18@gmail.com</email>
	/// <typeparam name="E">Tipo do objeto armazenado na coleção.</typeparam>
	public abstract class ArrayBase<E> : ICommon<E>, IDefaultComparator<E>, IClearCollection
	{
		/// <summary>
		/// Constante que define um valor inicial padrão para a coleção.
		/// </summary>
		protected int MAXSIZEDEFAULT { get; } = 100;

		/// <summary>
		/// Fornece um método de comparação para os objetos da coleção.
		/// </summary>
		public Comparison<E> Comparator { get; set; }

		/// <summary>
		/// Vetor que armazena os objetos genéricos da coleção.
		/// </summary>
		protected E[] Vector { get; set; }

        /// <summary>
        /// Indexador utilizado na coleção para auxiliar.
        /// </summary>
        /// <param name="i">Índice da coleção</param>
        /// <returns></returns>
        public E this[int i]
        {
            get { return Vector[i]; }
            set { Vector[i] = value; }
        }


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
			protected set
			{
				if (value < maxSize)
					throw new ValueNotValidException("Max size can't be less than current!");
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

		/// <summary>
		/// 
		/// </summary>
		/// <param name="maxSize">Valor máximo de itens que a coleção pode armazenar.</param>
		/// <param name="resizable">Define se a coleção deve se expandir ao atingir a capacidade máxima.</param>
		/// <param name="comparator">Fornece um método de comparação para os objetos da coleção.</param>
		protected ArrayBase(int maxSize, bool resizable = true, Comparison<E> comparator = null)
		{
			MaxSize		= maxSize;
			ResizeValue = MAXSIZEDEFAULT;
			Vector		= new E[maxSize];
			Resizable	= resizable;
			Comparator	= comparator;
		}

        protected ArrayBase(): this(100, true,null)
        {
        }


        /// <summary>
        /// Remove todos os objetos da coleção. Por fim, inutiliza a coleção.
        /// </summary>
        public void DisposeCollection()
		{
            Vector = null;
			Length = 0;
		}


        /// <summary>
        /// Remove todos os objetos da coleção.
        /// </summary>
        public void ClearCollection()
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
		/// Percorre a coleção até encontrar o objeto. Somente retorna o objeto não o remove. É necessário definir um Comparator a coleção.
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
		/// <exception cref="FullCollectionException">A coleção não foi configurada para aumentar dinamicamente seu tamanho a medida do necessário.</exception>
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
