using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.exception;

namespace Algorithms._abstract
{
	abstract class Node<E>
	{
		private E value;
		public E Value
		{
			get { return value; }
			set
			{
				this.value = value;
			}
		}

		public Node(E value)
		{
			Value = value;
		}

		public Node()
		{
			Value = value;
		}
	}
}
