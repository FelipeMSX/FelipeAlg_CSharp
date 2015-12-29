﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Algorithms._interface;
using Algorithms.exception;

namespace Algorithms._abstract
{
	internal abstract class StaticStruct<E> : ICommon<E>
	{
		protected E[] vector;
		protected E[] Vector
		{
			get { return vector; }
			set { vector = value; }
		}

		protected int currentSize;
		protected int CurrentSize
		{
			get { return currentSize; }
			set { currentSize = value; }
		}

		protected int maxSize = 100;
		protected int MaxSize
		{
			get { return maxSize; }
			set { MaxSize = value; }
		}

		public bool canExtend = true;
		/// <summary>
		/// Se true, indica que a coleção terá um crescimento autônomo.
		/// Se false, lança uma exceção ao tentar inserir um item com a capacidade no limite.
		/// Default = true.
		/// </summary>
		public bool CanExtend
		{
			get { return canExtend; }
			set { canExtend = value; }
		}

		/// <summary>
		/// Inicializa com o valor padrão que é 100.
		/// </summary>
		public StaticStruct()
		{
			vector = new E[MaxSize];
		}

		/// <summary>
		/// Inicializa com o valor de acordo com o parâmetro.
		/// </summary>
		/// <param name="initialSize"></param>
		public StaticStruct(int initialSize)
		{
			MaxSize = initialSize;
			vector = new E[MaxSize];
		}

		/// <summary>
		/// Dobra a capacidade do vetor de acordo com o MaxSize.
		/// </summary>
		protected void DoubleCapacity()
		{
			MaxSize *= 2;
			E[] newVector = new E[MaxSize];
			for (int i = 0; i < CurrentSize; i++)
			{
				newVector[0] = vector[i];
			}
			Vector = newVector;
		}

		#region métodos da interface
		/// <summary>
		/// Retorna o primeiro item da coleção sem removê-lo.
		/// </summary>
		/// <returns></returns>
		public virtual E FirstItem()
		{
			if (IsEmpty())
				throw new EmptyCollectionException();
			else
				return Vector[0];
		}

		/// <summary>
		/// Retorna o último item da coleção sem removê-lo.
		/// </summary>
		/// <returns></returns>
		public virtual E LastItem()
		{
			if (IsEmpty())
				throw new EmptyCollectionException();
			else
				return Vector[currentSize - 1];
		}

		/// <summary>
		/// Indica se a lista está vazia.
		/// </summary>
		/// <returns></returns>
		public bool IsEmpty()
		{
			return CurrentSize == 0;
		}

		/// <summary>
		/// Indica se a lista está com sua capacidade no limite.
		/// </summary>
		/// <returns></returns>
		public bool IsFull()
		{
			return currentSize == MaxSize;
		}

		/// <summary>
		/// Retorna o atual tamanho da coleção.
		/// </summary>
		/// <returns></returns>
		public int Size()
		{
			return CurrentSize;
		}
		#endregion
	}
}
