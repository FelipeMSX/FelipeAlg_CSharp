﻿using Algorithms.Interfaces;
using Algorithms.Utils;
using System;
using System.Collections.Generic;

namespace Algorithms.Sorts
{

    /*
	Descrição:
		- Aceita valores iguais.
        - O pivô é o elemento do meio.
        - Ordem Crescente.
	*/
    public class QuickSort<E> : IDefaultComparator<E>
    {
		public Comparison<E> Comparator { get; set; }
		
		public QuickSort(Comparison<E> comparator)
		{
			this.Comparator = comparator;
		}

        /// <summary>
        /// Ordena os elementos da lista utilizando a própria lista.
        /// <para>Aceita valores iguais e ordem crescente.</para>
        /// </summary>
        /// <param name="list">Lista de elementos para ordenação.</param>
		public void Sort(IList<E> list)
		{
			Quicksort(list, 0, list.Count -1);
		}

		private void Quicksort(IList<E> list, int init, int end)
		{
			if (init < end)
			{
				int pivot = Partition(list, init, end);
				Quicksort(list, init, pivot - 1);
				Quicksort(list, pivot + 1, end);
			}
		}

		private int Partition(IList<E> list, int init, int end)
		{
			int positionPivot = DefinePivot(init, end);
			//Ao definir o pivô é preciso colocá-lo no fim.
			ListFunctions.Swap(list, end, positionPivot);
			positionPivot = end;
			int left = init;
			int right = end - 1;

            // Rodar enquato left&right não se cruzarem no vetor.
            // Varra com left da esquerda para direita o vetor até encontrar o elemento maior que o pivô.
            // Varra com right da direita para esquerda o vetor até encontrar o elemento menor que o pivô.
            while (left <= right)
            {
                while ((left <= right) && Comparator(list[left], list[positionPivot]) <= 0)
                    left++;

                while ((left <= right) && Comparator(list[right], list[positionPivot]) > 0)
                    right--;

                if (left < right)
                {
                    ListFunctions.Swap(list, left, right);
                }
                else
                {
                    ListFunctions.Swap(list, left, positionPivot);
                    positionPivot = left;
                }
            }
            return positionPivot;
        }

        /// <summary>
        /// Define qual pivô vai ser selecionado.
        /// </summary>
        /// <param name="init">Posição inicial do vetor.</param>
        /// <param name="end">Posição final da lista.</param>
        /// <returns>Retorna o elemento do meio.</returns>
		private int DefinePivot(int init, int end)
		{
			return init + (end - init) / 2;
		}
	}
}