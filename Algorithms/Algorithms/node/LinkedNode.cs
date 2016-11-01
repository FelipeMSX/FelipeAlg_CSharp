using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms._abstract;

namespace Algorithms.node
{
	class LinkedNode<E> : Node<E>
	{
		public LinkedNode<E> Next { get; set; }

		public LinkedNode() : base()
		{

		}
		public LinkedNode(E obj) : base(obj)
		{		
		}

		public bool HasNext()
		{
			return Next != null;
		}
	}
}
