using System;
using Algorithms.Exceptions;
using Algorithms.Nodes;

namespace Algorithms.Structs
{
	/// <summary>
	/// Classe que define uma estrutura de dados do tipo lista ordenada.
	/// A lista está somente em ordem crescente.
	/// </summary>
	/// <author>Felipe Morais</author>
	/// <email>felipemsx18@gmail.com</email>
	/// <typeparam name="E">Tipo de objeto da lista.</typeparam>
	class OrderedLinkedList<E> : LinkedList<E>
	{
		/// <summary>
		/// Define se a coleção aceita objetos iguais.
		/// </summary>
		public bool AllowEquals { get; private set; }

		/// <param name="comparator">Especifica um comparador para a lista.</param>
		/// <param name="allowEquals">Especifica se a coleção aceita objetos iguais.</param>
		public OrderedLinkedList(Comparison<E> comparator, bool allowEquals = true) : base()
		{
			Comparator = comparator;
			AllowEquals = allowEquals;	
		}

		/// <summary>
		/// Adiciona um elemento a lista ordenada, não deve ser nulo.
		/// </summary>
		/// <exception cref="NullObjectException">Objeto não pode ser nulo.</exception>
		/// <exception cref="ComparerNotSetException">É necessário definir o comparador.</exception>
		/// <exception cref="EqualsElementException">Não é permitido objetos iguais na coleção.</exception>
		/// <param name="obj">Novo objeto a ser adicionado na coleção.</param>
		public override void Insert(E obj)
		{
			if (obj == null)
				throw new NullObjectException();
			if (Comparator == null)
				throw new ComparerNotSetException();

			LinkedNode<E> newNode = new LinkedNode<E>(obj);
			if (Empty())
			{
				Head.Next = newNode;
			} 
			else
			{
				LinkedNode<E> search = Head.Next;
				LinkedNode<E> previous = Head.Next;

				while (search != null)
				{
					//Valida se é permitido objetos iguais na coleção.
					if (Comparator(search.Value, obj) == 0 && !AllowEquals)
						throw new EqualsElementException();

					if (Comparator(search.Value, obj) >= 0)
					{
						previous.Next = newNode;
						newNode.Next = search;
						break;
					}
					previous = search;
					search = search.Next;
				}
				previous.Next = newNode;
			}
			Length++;
		}
	}
}
