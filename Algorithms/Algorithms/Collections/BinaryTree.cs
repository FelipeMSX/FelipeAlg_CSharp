using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Abstacts;
using Algorithms.Nodes;

namespace Algorithms.Collections
{
	public class BinaryTree<T> : SearchTreeBase<T, TreeSearchNode<T>>
	{


		public override void Insert(T value)
		{
			throw new NotImplementedException();
		}

		public override T Remove(T value)
		{
			throw new NotImplementedException();
		}

		public override T Retrieve(T value)
		{
			throw new NotImplementedException();
		}

		public override IEnumerator<T> GetEnumerator()
		{
			throw new NotImplementedException();
		}
	}
}
