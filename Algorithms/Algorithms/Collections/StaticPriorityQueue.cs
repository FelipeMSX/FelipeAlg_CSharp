using System;
using Algorithms.Collections;
using Algorithms.Exceptions;

namespace Algorithms.Collections
{
    /// <summary>
    /// Classe que define uma estrutura de dados do tipo fila de prioridade.
    /// <para>Elementos iguais são colocados no fim da lista.</para>
    /// <para> Elementos com maior prioridade estão no início do vetor.</para>
    /// </summary>
    /// <author>Felipe Morais</author>
    /// <email>felipemsx18@gmail.com</email>
    /// <typeparam name="E">Tipo de objeto da fila de prioridade.</typeparam>
    public class StaticPriorityQueue<E> : StaticQueue<E>
	{
		public StaticPriorityQueue() : base()
		{
		}

		/// <param name="maxsize">Valor máximo de itens que a coleção pode armazenar.</param>
		public StaticPriorityQueue(int maxSize): base(maxSize)
		{
		}

		/// <param name="maxsize">Valor máximo de itens que a coleção pode armazenar.</param>
		/// <param name="resizable">Define se a coleção deve se expandir ao atingir a capacidade máxima.</param>
		/// <param name="comparator">Fornece um método de comparação para os objetos da coleção.</param>
		public StaticPriorityQueue(int maxsize, bool resizable, Comparison<E> comparator) : base (maxsize, resizable, comparator)
		{
		}

		/// <summary>
		/// Adiciona um elemento e procura a posição dele a ser inserido na fila de prioridade.
        /// Elementos repetidos são adicionados no fim.
		/// </summary>
		/// <exception cref="NullReferenceException">Objeto a ser inserido não pod ser nulo.</exception>
		/// <exception cref="ComparerNotSetException">Comparador deve ser definido.</exception>
		/// <exception cref="FullCollectionException">A coleção está cheia.</exception>
		/// <param name="obj">Objeto a ser inserido na fila de prioridade.</param>
		public override void Push(E obj)
		{
			if (obj == null)
				throw new NullObjectException();
			if (Comparator == null)
				throw new ComparerNotSetException();
			if (Full())
				IncreaseCapacity();

			int position = 0;
			//Encontra a posição do item a ser colocado.
			while (Length-1 >= position && Comparator(obj, Vector[position]) <= 0)
				position++;

            Length++;
            //Desloca os itens uma posição a frente para colocar o objeto no lugar.
            for (int i = Length - 1; i > position; i--)
			{
				Vector[i] = Vector[i-1];
			}

			Vector[position] = obj;
			
		}
	}
}
