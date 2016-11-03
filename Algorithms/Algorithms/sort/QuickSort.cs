using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.exception;

namespace Algorithms.sort
{

	/*
	Descrição:
		- Aceita valores iguais.
        - O pivô é o elemento do meio.
        - Ordem Crescente.
	*/
	class QuickSort<E>
	{
		private Comparison<E> Comparator { get; set; }
		
		QuickSort(Comparison<E> comparator)
		{
			this.Comparator = comparator;
		}

		public void Sort(E[] input)
		{
			Quicksort(input, 0, input.Length);
		}

		private void Quicksort(E[] input, int init, int end)
		{
			if (init < end)
			{
				int pivot = Partition(input, init, end);
				Quicksort(input, init, pivot - 1);
				Quicksort(input, pivot + 1, end);
			}
		}

		private int Partition(E[] input, int init, int end)
		{
			int positionPivot = DefinePivot(init, end);
			//Ao definir o pivô é preciso colocá-lo no fim.
			Swap(input, end, positionPivot);
			positionPivot = end;
			int left = init;
			int right = end - 1;

			// Rodar enquato left&right não se cruzarem no vetor.
			// Varra com left da esquerda para direita o vetor até encontrar o elemento maior que o pivô.
			// Varra com right da direita para esquerda o vetor até encontrar o elemento menor que o pivô.
			while (left <= right)
			{
			
				while ((left <= right) && Comparator(input[left], input[positionPivot]) <= 0)
					left++;

				while ((left <= right) && Comparator(input[right], input[positionPivot]) > 0)
					right--;

				if (left < right)
				{
					Swap(input, left, right);
				}
				else
				{
					Swap(input, left, positionPivot);
					positionPivot = left;
				}
			}
			return positionPivot;
		}

		private void Swap(E[] input, int X, int Y)
		{
			E temp = input[X];
			input[X] = input[Y];
			input[Y] = temp;
		}

		private int DefinePivot(int init, int end)
		{
			return init + (end - init) / 2;
		}
	}
}
