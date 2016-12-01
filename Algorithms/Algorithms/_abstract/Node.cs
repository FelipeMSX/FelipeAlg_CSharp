namespace Algorithms._abstract
{
	/// <summary>
	/// Classe que tem como função armazenar um objeto qualquer.
	/// </summary>
	public abstract class Node<E>
	{
		public E Value{ get; set; }

		public Node(E value)
		{
			Value = value;
		}

		public Node()
		{
		}
	}
}
