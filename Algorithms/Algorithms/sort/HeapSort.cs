using Algorithms._interface;
using Algorithms.util;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Algorithms.sort
{
    /// <summary>
    /// 
    /// </summary>
    /// <author>Felipe Morais</author>
    /// <email>felipemsx18@gmail.com</email>
    /// <typeparam name="E"></typeparam>
   public class HeapSort<E> : IDefaultComparator<E>
    {
        public Comparison<E> Comparator { get; set; }

        /// <summary>
        /// Indica se o Heap será construído com o maior valor no top da árvore"MAX", 
        /// ou o menor valor no top da árvore "MIN".
        /// </summary>
        public enum Build { Max, Min };

        /// <summary>
        /// Indica como o heap foi construído. Max ou Min.
        /// </summary>
        public Build Operation { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="comparator">Define a forma que os elementos serão comparados na lista</param>
        /// <param name="build">Indica como o heap foi construído.</param>
        public HeapSort(Comparison<E> comparator, Build build)
		{
			Comparator = comparator;
            Operation = build;
		}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="comparator">Define a forma que os elementos serão comparados na lista</param>
        public HeapSort(Comparison<E> comparator) : this(comparator, Build.Max){}

        /// <summary>
        /// Ordena os elementos de um vetor utilizando o algoritmo do HeapSort
        /// </summary>
        /// <param name="list"></param>
		public void Sort(IList<E> list)
		{
			Heapsort(list);
		}

		private void Heapsort(IList<E> list)
		{
			BuildMinHeap(list, list.Count);
			int i;
			for (i = list.Count - 1; i > 0; i--)
			{
				Util.SwapItem(list, 0, i);
				MinHeapify(list, 0, i);
			}
		}

		private void MinHeapify(IList<E> input, int i, int position)
		{
			int P = i;
			int leftPosition = Left(i);
			int rightPosition = Right(i);

            // leftPosition < position. Verfica o filho esquerdo existe, verificando se não extrapola os limites do vetor.
            // Se o filho esquerdo for maior que o pai é necessário trocar.
            if (leftPosition < position && Comparator(input[leftPosition], input[P]) >= 0)
				P = leftPosition;

            // rightPosition < position. Verfica o filho direito existe, verificando se não extrapola os limites do vetor.
            // Se o filho direito for maior que o pai é necessário trocar.
            if (rightPosition < position && Comparator(input[rightPosition], input[P]) >= 0)
				P = rightPosition;

			if (P != i)
			{
				Util.SwapItem(input, i, P);
				MinHeapify(input, P, position);
			}

		}

		private void BuildMinHeap(IList<E> vector, int position)
		{
			for (int i = position / 2 ; i > 0; i--)
				MinHeapify(vector, i, position);
		}


        private void MaxHeapify(IList<E> input, int i, int position)
        {
            int P = i;
            int E = Left(i);
            int D = Right(i);

            if (E < position && Comparator(input[E], input[P]) >= 0)
                P = E;

            if (D < position && Comparator(input[D], input[P]) >= 0)
                P = D;

            if (P != i)
            {
                Util.SwapItem(input, i, P);
                MaxHeapify(input, P, position);
            }

        }

        private void BuildMaxHeap(IList<E> vector, int position)
        {
            for (int i = position / 2 - 1; i >= 0; i--)
                MaxHeapify(vector, i, position);
        }


        private int Father(int i)
		{
			return (i - 1) / 2;
		}

		private int Left(int i)
		{
			return 2 * i + 1;
		}

		private int Right(int i)
		{
			return 2 * i + 2;
		}

	}
}
