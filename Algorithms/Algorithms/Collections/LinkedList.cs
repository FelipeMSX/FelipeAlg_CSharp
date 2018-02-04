using System;
using System.Collections.Generic;
using Algorithms.Abstacts;
using Algorithms.Exceptions;
using Algorithms.Nodes;

namespace Algorithms.Collections
{
	/// <summary>
	/// Classe que define uma estrutura de dados do tipo lista encadeada.
	/// </summary>
	/// <author>Felipe Morais</author>
	/// <email>felipemsx18@gmail.com</email>
	/// <typeparam name="E">Tipo de objeto da lista.</typeparam>
	public class LinkedList<E> : LinkedListBase<E, LinkedNode<E>>
	{

        public LinkedList(Comparison<E> comparator) : base()
        {
            Head = new LinkedNode<E>();
            Comparator = comparator;
        }

        public LinkedList() : this(null)
		{
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
				Head.Next = newNode;
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

			//Remoção na cabeça da coleção.
			if (Comparator(Head.Next.Value, obj) == 0)
                return RemoveNodeFromList(Head);
            //Caso quando a coleção possui vários elementos e é preciso procurar o elemento.
			else
			{
                LinkedNode<E> previous = SearchPreviousPosition(obj);

                if (previous != null)
                    return RemoveNodeFromList(previous);
                else
                    throw new ElementNotFoundException();
            }
		}

        private E RemoveNodeFromList(LinkedNode<E> previousNode)
        {
            LinkedNode<E> current = previousNode.Next;
            previousNode.Next     = current.Next; 
            current.Next          = null;
            Length--;
            return current.Value;
        }

        private LinkedNode<E> SearchPreviousPosition( E objectKey)
        {
            LinkedNode<E> search = Head.Next;
            LinkedNode<E> previous = Head.Next;

            while (previous.HasNext())
            {
                if (Comparator(search.Value, objectKey) == 0)
                    return previous;

                previous = search;
                search = search.Next;
            }
            return null;
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
			while (current.HasNext() && Comparator(current.Value, obj) != 0)
			{
				current = current.Next;
			}
           
			return Comparator(current.Value, obj) == 0 ? current.Value : default(E);
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
			LinkedNode<E> current = Head;
			while (current.HasNext())
			{
                current = current.Next;
                yield return current.Value;
				
			}
		}

        /// <summary>
        /// Remove todos os elementos da coleção.
        /// </summary>
        public override void Clear()
        {
            Head.Next   = null;
            Length      = 0;
        }
    }
}
