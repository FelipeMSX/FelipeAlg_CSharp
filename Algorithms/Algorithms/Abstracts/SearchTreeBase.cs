using System;
using System.Collections;
using System.Collections.Generic;
using Algorithms.Interfaces;
using Algorithms.Nodes;

namespace Algorithms.Abstacts
{
	public abstract class SearchTreeBase<E, T> : IEnumerable<E>, IDefaultComparator<E>
		where T : TreeSearchNode<E>
	{
        /// <summary>
        /// Root não contém dados, é o "ponteiro" para o primeiro objeto da árvore.
        /// </summary>
		protected T Root { get; set;}
		public int Length { get; protected set; }

		public abstract void Insert(E value);
		public abstract E Remove(E value);
		public abstract E Retrieve(E value);
		
		public bool IsEmpty() => Length == 0;

		public Comparison<E> Comparator { get; set; }

		public abstract IEnumerator<E> GetEnumerator();

		IEnumerator IEnumerable.GetEnumerator()
		{
			throw new NotImplementedException();
		}
	}
}
