namespace Algorithms.Abstacts
{
	/// <summary>
	/// Classe que tem como função armazenar um objeto qualquer.
	/// </summary>
	/// <author>Felipe Morais</author>
	/// <email>felipemsx18@gmail.com</email>
	public abstract class NodeBase<E>
	{
		public E Value{ get; set; }

		protected NodeBase(E value)
		{
			Value = value;
		}

        protected NodeBase()
		{  
		}
	}
}
