﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.exception;

namespace Algorithms._abstract
{
	/// <summary>
	/// Classe que possui um objeto genérico como atribuito.
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
