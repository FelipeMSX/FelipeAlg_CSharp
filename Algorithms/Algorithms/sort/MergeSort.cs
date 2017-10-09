using Algorithms._interface;
using System;

namespace Algorithms.sort
{
    /// <summary>
    /// </summary>
    /// <author>Felipe Morais</author>
    /// <email>felipemsx18@gmail.com</email>
    /// <typeparam name="E"></typeparam>
    public class MergeSort<E> : IDefaultComparator<E>
    {
		/// <summary>
		/// Método que compara dois objetos e retorna um inteiro.
		/// </summary>
		public Comparison<E> Comparator{ get; set; }

		/// <summary>
		/// Armazena os objetos que serão utilizados na ordenação.
		/// </summary>
		private E[] _vector;

		/// <param name="comparator">Método que compara dois objetos e retorna um inteiro.</param>
		public MergeSort(Comparison<E> comparator)
		{
			Comparator = comparator;
		}

		/// <summary>
		/// Ordena o vetor utilizando o algoritmo do mergesort.
		/// </summary>
		/// <param name="input">Vetor com os objetos genéricos.</param>
		public void Sort(E[] input)
		{
			Mergesort(input, input.Length);
		}

		private void Mergesort(E[] input, int length)
		{
			_vector = new E[length];
			Merge(input, 0, length - 1);
		}

		/// <summary>
		/// Parte recursiva do algoritmo que chama recursivamente a metade esquerda e direita.
		/// O algoritmo só irá parar quando fazer uma divisão com um elemento só, a partir daí o algoritmo retrocede a chamadas anteriores ordenando os elementos devidamente.
		/// </summary>
		/// <param name="input">Vetor com todos os dados.</param>
		/// <param name="init">Índice da posição inicial do vetor.</param>
		/// <param name="end">ìndice da posição final do vetor.</param>
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
					_vector[k++] = input[i++];
				// Se i > meio, significa que não existe mais elementos do inicio ao fim para comparar, agora é só adicioar do meio +1 ao fim.
				else if (i > middle)
					_vector[k++] = input[j++];
				else if (Comparator(input[i], input[j]) <= 0)
					_vector[k++] = input[i++];
				else
					_vector[k++] = input[j++];
			}

			//Copiar os elementos para o vetor entrada
			for (int w = init; w <= end; w++)
				input[w] = _vector[w];
		}

	}
}
