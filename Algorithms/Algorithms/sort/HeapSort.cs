﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms._interface;
using Algorithms.exception;
using Algorithms.util;

namespace Algorithms.sort
{
	class HeapSort<E> : DefaultComparator<E>
	{
		public Comparison<E> Comparator { get; set; }

		HeapSort(Comparison<E> comparator)
		{
			Comparator = comparator;
		}

		public void Sort(E[] input)
		{
			Heapsort(input, input.Length);
		}

		private void Heapsort(E[] input, int n)
		{
			BuildMinHeap(input, n);
			int i;
			for (i = n - 1; i > 0; i--)
			{
				Util.SwapItem(input, 0, i);
				MinHeapify(input, 0, i);
			}
		}

		private void MinHeapify(E[] input, int i, int n)
		{
			int P = i;
			int E = Left(i);
			int D = Right(i);
		
			if (E < n && Comparator(input[E], input[P]) >= 0)
				P = E;

			if (D < n && Comparator(input[D], input[P]) >= 0)
				P = D;

			if (P != i)
			{
				Util.SwapItem(input, i, P);
				MinHeapify(input, P, n);
			}

		}

		private void BuildMinHeap(E[] input, int n)
		{
			for (int i = n / 2 - 1; i >= 0; i--)
				MinHeapify(input, i, n);
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
