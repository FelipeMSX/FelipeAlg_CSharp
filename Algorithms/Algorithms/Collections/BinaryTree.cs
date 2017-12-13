using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Abstacts;
using Algorithms.Nodes;

namespace Algorithms.Collections
{
	public class BinaryTree<E> : SearchTreeBase<E, TreeSearchNode<E>>
	{


		public override void Insert(E value)
		{
			throw new NotImplementedException();
		}

		public override E Remove(E value)
		{
			throw new NotImplementedException();
		}

		public override E Retrieve(E value)
		{
			throw new NotImplementedException();
		}

		public override IEnumerator<E> GetEnumerator()
		{
			throw new NotImplementedException();
		}
	}
}
