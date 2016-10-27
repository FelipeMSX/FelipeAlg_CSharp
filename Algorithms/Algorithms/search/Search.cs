using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Algorithms.exception;

namespace Algorithms.search
{
	/// Autor: Felipe Morais; 
	/// E-mail:felipemsx18@gmail.com

	public class Search<E>
	{
		private Comparison<E> Comparer;

		public Search(Comparison<E> comparer)
		{
			Comparer = comparer;
		}

		public E BinarySearch(E[] array, E item)
		{
			if (Comparer == null)
				throw new ComparerNotSetException();

			int left = 0;
			int right = array.Length - 1;
			int mid = 0;

			while (left <= right)
			{
				mid = midvalue(left, right);
				// Se o valor do item a ser achado for maior ao do array é necessário avançar para direita.
				// arrayItem < item
				;
				if (Comparer(array[mid], item) <= -1)
					left = mid + 1;
				else
				// Se o valor do item a ser achado for menor ao do array é necessário avançar para esquerda.
				// arrayItem > item
				if (Comparer(array[mid], item) >= 1)
					right = mid - 1;
				else
					return array[mid];
			}
			return default(E);
		}

		private  int midvalue(int left, int right)
		{
			return left + (right - left) / 2;
		}
	}
}
