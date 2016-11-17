using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms._abstract;

namespace Algorithms.node
{
	public class LinkedDoubleNode<E> : Node<E>
	{
		public LinkedDoubleNode<E> Previous { get; set; }
		public LinkedDoubleNode<E> Next { get; set; }

		public LinkedDoubleNode() : base()
		{
		}

		public LinkedDoubleNode(E obj) : base(obj)
		{

		}

		public bool HasNext()
		{
			return Next != null;
		}

		public bool HasPrevious()
		{
			return Previous != null;
		}
	}
}
