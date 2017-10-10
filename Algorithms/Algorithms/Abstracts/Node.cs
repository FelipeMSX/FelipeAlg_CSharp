namespace Algorithms.Abstacts
{
	/// <summary>
	/// Classe que tem como função armazenar um objeto qualquer.
	/// </summary>
	/// <author>Felipe Morais</author>
	/// <email>felipemsx18@gmail.com</email>
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
