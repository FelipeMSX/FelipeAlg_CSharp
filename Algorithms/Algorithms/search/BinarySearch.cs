using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.search
{
	/// Autor: Felipe Morais; 
	/// E-mail:felipemsx18@gmail.com

	 sealed partial class BinarySearch<E> where E : IComparable
	{

		/// <summary>
		/// Deve ser passado como argumento um array ordenado e o objeto que deseja encontrar com suas respectivas keys, se não encontrar o objeto retorna null.
		/// </summary>
		/// <param name="array"> Vetor ordenado</param>
		/// <param name="item"></param>
		public E Search(E[] array, E item)
		{
			int left = 0;
			int right = array.Length - 1;
			int mid = 0;

			while (left <= right)
			{
				mid = midvalue(left, right);
				// Se o valor do item a ser achado for maior ao do array é necessário avançar para direita.
				// arrayItem < item
				if (array[mid].CompareTo(item) <= -1)
					left = mid + 1;
				else
				// Se o valor do item a ser achado for menor ao do array é necessário avançar para esquerda.
				// arrayItem > item
				if (array[mid].CompareTo(item) >= 1)
					right = mid - 1;
				else
					return array[mid];
			}
			return default(E);
		}

		private int midvalue(int left, int right)
		{
			return left + (right - left) / 2;
		}
	}
}
