using Algorithms.Exceptions;
using Algorithms.Interfaces;
using System;
using System.Collections.Generic;

namespace Algorithms.Searchs
{

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="E"></typeparam>
    /// <author>Felipe Morais</author>
	/// <email>felipemsx18@gmail.com</email>
    public class Search<E> : IDefaultComparator<E>
	{
		public Comparison<E> Comparator { get; set; }

		public Search(Comparison<E> comparer)
		{
			Comparator = comparer;
		}

		/// <summary>
		/// Utiliza a busca binária para encontrar um objeto no vetor.
		/// O vetor deve estar ordenado para funcionar.
		/// </summary>
		/// <param name="orderedArray">Array com itens ordenados.</param>
		/// <param name="item">Objeto almejado.</param>
		/// <returns>Retorna o objeto caso exista, caso contrário, valor padrão do objeto.</returns>
		public E BinarySearch(IList<E> orderedArray, E item)
		{
			if (Comparator == null)
				throw new ComparerNotSetException();

			int left = 0;
			int right = orderedArray.Length - 1;
			int mid = 0;

			while (left <= right)
			{
				mid = MidValue(left, right);
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
			return default(E);
		}

		private  int MidValue(int left, int right)
		{
			return left + (right - left) / 2;
		}
	}
}
