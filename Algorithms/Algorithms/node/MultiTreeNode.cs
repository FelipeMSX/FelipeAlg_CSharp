using Algorithms._abstract;

namespace Algorithms.node
{
	public class MultiTreeNode<E> : Node<E>
	{

		/// <summary>
		/// Representa um ponteiro para um node pai.
		/// </summary>
		public MultiTreeNode<E> Father { get; set; }

		//public LinkedList<MultiTreeNode<E>> NodeList { get; set; }

		public MultiTreeNode() : base()
		{
		}

		/// <param name="obj">Objeto genérico que será armazenado no node.</param>
		public MultiTreeNode(E obj) : base(obj)
		{
		}

		/// <summary>
		/// Avalia se existe um node anterior ao atual.
		/// </summary>
		/// <returns>Retorna true se existir um node anterior, caso contrário, false.</returns>
		public bool HasFather() => Father != null;
	}
}
