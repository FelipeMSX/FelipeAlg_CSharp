﻿using Algorithms.Exceptions;
using Algorithms.Interfaces;
using System;
using System.Collections.Generic;

namespace Algorithms.Searchs
{

    /// <summary>
    /// 
    /// </summary>
    /// <author>Felipe Morais</author>
	/// <email>felipemsx18@gmail.com</email>
    public class Search<T> : ISearch<T>
	{
        /// <summary>
        /// Define um comparador padrão para o objeto de entrada.
        /// </summary>
        public Comparison<T> Comparator{ get; set; }

        /// <param name="comparator">Comparador utilizado nos objetos</param>
        public Search(Comparison<T> comparator)
        {
            this.Comparator = comparator;
        }
        /// <summary>
        /// Utiliza a busca binária para encontrar um objeto no vetor.
        /// O vetor deve estar ordenado para funcionar.
        /// </summary>
        /// <exception cref="NullObjectException">Objeto de entrada não pode ser nulo.</exception>
        /// <exception cref="ComparerNotSetException">Comparator não deve ser nulo.</exception>
        /// <param name="orderedArray">Array com itens ordenados.</param>
        /// <param name="item">Objeto almejado.</param>
        /// <returns>Retorna o objeto caso exista, caso contrário, valor padrão do objeto.</returns>
        public T BinarySearch(IList<T> orderedArray, T item)
		{
            //Validações
			if (Comparator == null)
				throw new ComparerNotSetException();

            if (item == null)
                throw new NullObjectException("The item can't be a null value!");

            if (orderedArray == null)
                throw new NullObjectException("The item can't be a null value!");

            int left = 0;
			int right = orderedArray.Count - 1;
			int mid = 0;

			while (left <= right)
			{
				mid = MidPosition(left, right);
				// Se o valor do item a ser achado for maior ao do array é necessário avançar para direita.
				// arrayItem < item
     
				if (Comparator(orderedArray[mid], item) <= -1)
					left = mid + 1;
				else
				// Se o valor do item a ser achado for menor ao do array é necessário avançar para esquerda.
				// arrayItem > item
				if (Comparator(orderedArray[mid], item) >= 1)
					right = mid - 1;
				else
					return orderedArray[mid];
			}
			return default(T);
		}
		private static int MidPosition(int left, int right)
		{
			return left + (right - left) / 2;
		}
	}
}
