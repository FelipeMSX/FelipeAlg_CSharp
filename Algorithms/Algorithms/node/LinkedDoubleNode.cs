using Algorithms._abstract;

namespace Algorithms.node
{
	/// <summary>
	/// Classe que representa uma estrutura com dois ponteiros,
	/// um ponteiro para frente e outro para trás. Contendo também um objeto qualquer.
	/// </summary>
	/// <author>Felipe Morais</author>
	/// <email>felipemsx18@gmail.com</email>
	/// <typeparam name="E"></typeparam>
	public class LinkedDoubleNode<E> : Node<E>
	{
		/// <summary>
		/// Representa um ponteiro para um node anterior.
		/// </summary>
		public LinkedDoubleNode<E> Previous { get; set; }

		/// <summary>
		/// Representa um ponteiro para um node posterior.
		/// </summary>
		public LinkedDoubleNode<E> Next { get; set; }

		public LinkedDoubleNode() : base()
		{
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="obj">Objeto genérico que será armazenado no node.</param>
		public LinkedDoubleNode(E obj) : base(obj)
		{
		}

		/// <summary>
		/// Avalia se existe um próximo node.
		/// </summary>
		/// <returns>Retorna true se existir um próximo node, caso contrário, false.</returns>
		public bool HasNext()
		{
			return Next != null;
		}

		/// <summary>
		/// Avalia se existe um node anterior ao atual.
		/// </summary>
		/// <returns>Retorna true se existir um node anterior, caso contrário, false.</returns>
		public bool HasPrevious()
		{
			return Previous != null;
		}
	}
}
