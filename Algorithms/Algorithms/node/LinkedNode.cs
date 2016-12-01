using Algorithms._abstract;

namespace Algorithms.node
{
	/// <summary>
	/// Classe que representa uma estrutura com um ponteiro além de armazenar um objeto qualquer.
	/// </summary>
	/// <typeparam name="E"></typeparam>
	public class LinkedNode<E> : Node<E>
	{
		/// <summary>
		/// Representa um ponteiro para um node posterior.
		/// </summary>
		public LinkedNode<E> Next { get; set; }

		public LinkedNode() : base()
		{
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="obj">Objeto genérico que será armazenado no node.</param>
		public LinkedNode(E obj) : base(obj)
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
	}
}
