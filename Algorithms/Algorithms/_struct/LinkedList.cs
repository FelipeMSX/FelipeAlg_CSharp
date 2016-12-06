using System.Collections.Generic;
using Algorithms._abstract;
using Algorithms.exception;
using Algorithms.node;

namespace Algorithms._struct
{
	/// <summary>
	/// Classe que define uma estrutura de dados do tipo lista.
	/// </summary>
	/// <author>Felipe Morais</author>
	/// <email>felipemsx18@gmail.com</email>
	/// <typeparam name="E">Tipo de objeto da lista.</typeparam>
	public class LinkedList<E> : LinkedStruct<E, LinkedNode<E>>
	{

		public LinkedList() : base()
		{
			Head = new LinkedNode<E>();
		}

		/// <summary>
		/// Adiciona um elemento a lista, não deve ser nulo.
		/// </summary>
		/// <exception cref="NullObjectException">Objeto não pode ser nulo.</exception>
		/// <param name="obj">Novo objeto a ser adicionado na coleção.</param>
		public override void Insert(E obj)
		{
			if (obj == null)
				throw new NullObjectException();

			LinkedNode<E> newNode;
			newNode = new LinkedNode<E>(obj);
			if (Empty())
			{
				Head.Next = newNode;
			}
			else
			{
				LinkedNode<E> searchNode = Head.Next;

				while (searchNode.HasNext())
					searchNode = searchNode.Next;
				
				searchNode.Next = newNode;		
			}
			Length++;
		}

		/// <summary>
		/// Percorre a lista até encontrar o objeto, caso encontrado o objeto é desvincula e retornado.
		/// </summary>
		/// <exception cref="NullObjectException">Objeto de entrada não pode ser nulo.</exception>
		/// <exception cref="EmptyCollectionException">A lista está vazia.</exception>
		/// <exception cref="ComparerNotSetException">Comparator não deve ser nulo.</exception>
		/// <exception cref="ElementNotFoundException">Objeto não encontrado na lista.</exception>
		/// <param name="obj">Objeto do tipo da lista com as chaves necessárias para encontrar qualquer elemento na lista.</param>
		/// <returns></returns>
		public override E Remove(E obj)
		{
			//Validações
			if (obj == null)
				throw new NullObjectException();
			if (Empty())
				throw new EmptyCollectionException();
			if (Comparator == null)
				throw new ComparerNotSetException();

			//Caso a coleção contenha somente um elemento.
			if (Comparator(Head.Next.Value, obj) == 0)
			{
				LinkedNode<E> temp = Head.Next;
				Head.Next = temp.Next;
				Length--;
				return temp.Value;
				//Caso quando a coleção possui vários elementos e é preciso procurar o elemento.
			}
			else
			{
				LinkedNode<E> search = Head.Next;
				LinkedNode<E> previous = Head.Next;

				while (previous.HasNext())
				{
					if (Comparator(search.Value, obj) == 0)
					{
						previous.Next = search.Next;
						search.Next = null;
						Length--;
						return search.Value;
					}
					previous = search;
					search = search.Next;
				}
				throw new ElementNotFoundException();
			}
		}

		/// <summary>
		/// Recupera um objeto da coleção sem removê-lo.
		/// </summary>
		/// <param name="obj">Objeto utilizado como parâmetro chave para encontrar os dados.</param>
		/// <returns></returns>
		public override E Retrive(E obj)
		{
			if (Empty())
				throw new EmptyCollectionException();
			if (obj == null)
				throw new NullObjectException();
			if (Comparator == null)
				throw new ComparerNotSetException();

			LinkedNode<E> current = Head.Next;
			while (current != null && Comparator(current.Value, obj) != 0)
			{
				current = current.Next;
			}
			return current.Value;
		}

		/// <summary>
		/// Obtém o primeiro elemento da lista.
		/// </summary>
		/// <exception cref="EmptyCollectionException">A coleção está vazia.</exception>
		public override E First()
		{
			//Validações
			if (Empty())
				throw new EmptyCollectionException();

			return Head.Next.Value;
		}

		/// <summary>
		/// Obtém o último elemento da lista localizado no fim.
		/// </summary>
		/// <exception cref="EmptyCollectionException">Caso a coleção esteja vazia.</exception>
		public override E Last()
		{
			if (Empty())
				throw new EmptyCollectionException();

			LinkedNode<E> current = Head.Next;
			while (current.HasNext())
			{
				current = current.Next;
			}
			return current.Value;
		}
	
		/// <summary>
		/// Define um enumerador para a lista.
		/// </summary>
		public override IEnumerator<E> GetEnumerator()
		{
			LinkedNode<E> current = Head.Next;
			while (current != null)
			{
				yield return current.Value;
				current = current.Next;
			}
		}
	}
}
