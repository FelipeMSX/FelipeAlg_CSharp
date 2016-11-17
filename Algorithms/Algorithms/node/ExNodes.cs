using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.node
{
	public class Normal<E>
	{
		public LinkedNode<E> Next { get; set; }
	}

	public class Double<E>
	{
		public LinkedDoubleNode<E> Next { get; set; }
		public LinkedDoubleNode<E> Previous { get; set; }
	}
}
