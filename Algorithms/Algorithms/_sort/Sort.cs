using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.sort
{
	/// Autor: Felipe Morais; 
	/// E-mail:felipemsx18@gmail.com

	static class Sort<E> where E : IComparable<E>
	{
		#region MergeSort
		private static E[] mergeAuxiliar;

		public static E[] MergeSort(E[] input)
		{
			mergeAuxiliar = new E[input.Length];
			merge(input, 0, input.Length - 1);
			return mergeAuxiliar;
		}


		private static void merge(E[] input, int ini, int end)
		{
			if (ini < end)
			{
				int middle = ini + (end - ini) / 2;
				merge(input, ini, middle);
				merge(input, middle + 1, end);
				intercalate(input, ini, middle, end);
			}
		}

		private static void intercalate(E[] input, int init, int middle, int end)
		{
			int i = init;
			int j = middle + 1;
			int k = init; // controlador do vetor output, a cada adição no vetor, é incrementado

			while (i <= middle || j <= end)
			{

				// Se já passou do fim, significa que não possui mais elementos do meio pro fim para inserir no vetor
				if (j > end)
					mergeAuxiliar[k++] = input[i++];
				// Se i > meio, significa que não existe mais elementos do inicio ao fim para comparar, agora é só adicioar do meio +1 ao fim.
				else if (i > middle)
					mergeAuxiliar[k++] = input[j++];
				else if (input[i].CompareTo(input[j]) <= 0)
					mergeAuxiliar[k++] = input[i++];
				else
					mergeAuxiliar[k++] = input[j++];
			}
			//Copiar os elementos para o vetor entrada
			for (int w = init; w <= end; w++)
				input[w] = mergeAuxiliar[w];
		}

		#endregion

		#region QuickSortPadrao
		public static E[] QuickSort(E[] input)
		{
			QuickSortAuxiliator(input, 0,input.Length-1);
			return input;
		}

		private static void QuickSortAuxiliator(E[] input, int inicio, int fim)
		{
			if (inicio < fim)
			{
				int pivo = Partition(input, inicio, fim);
				QuickSortAuxiliator(input, inicio, pivo - 1);
				QuickSortAuxiliator(input, pivo + 1, fim);
			}
		}

		//PP : particionar padrão
		private static int Partition(E[] input, int init, int end)
		{
			E pivo = input[end]; // pivô escolhido no final
			int i = init - 1, j;
			for (j = init; j < end; j++)
			{
				if (input[j].CompareTo(pivo) <= 0)
				{
					i = i + 1;
					Swap(input, i, j);
				}
			}

			Swap(input, i + 1, end);
			return i + 1;
		}

		private static void Swap(E[] input, int positionX, int positionY)
		{
			E temp = input[positionX];
			input[positionX] = input[positionY];
			input[positionY] = temp;
		}
		#endregion

		public static E[] HeapSort()
		{
			return null;
		}
	}
}
