using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.exception;

namespace Algorithms.sort
{
	class MergeSort<E>
	{
		public Comparison<E> Comparator{ get; set; }

		private E[] Vector;

		MergeSort(Comparison<E> comparator)
		{
			Comparator = comparator;
		}

		public void Sort(E[] input)
		{
			Mergesort(input, input.Length);
		}

		private void Mergesort(E[] input, int length)
		{
			Vector = new E[length];
			Merge(input, 0, length - 1);
		}

		private void Merge(E[] input, int init, int end)
		{
			if(init < end)
			{
				int middle = init + (end - init) / 2;
				Merge(input, init, middle);
				Merge(input, middle + 1, end);
				Intercalate(input, init, middle, end);
			}
		}

		private void Intercalate(E[] input, int init, int middle, int end)
		{
			int i = init;
			int j = middle + 1;
			int k = init; // controlador do vetor output, a cada adição no vetor, é incrementado

			while (i <= middle || j <= end)
			{
				// Se já passou do fim, significa que não possui mais elementos do meio pro fim para inserir no vetor
				if (j > end)
					Vector[k++] = input[i++];
				// Se i > meio, significa que não existe mais elementos do inicio ao fim para comparar, agora é só adicioar do meio +1 ao fim.
				else if (i > middle)
					Vector[k++] = input[j++];
				else if (Comparator(input[i], input[j]) <= 0)
					Vector[k++] = input[i++];
				else
					Vector[k++] = input[j++];
			}

			//Copiar os elementos para o vetor entrada
			for (int w = init; w <= end; w++)
				input[w] = Vector[w];
		}

	}
}
