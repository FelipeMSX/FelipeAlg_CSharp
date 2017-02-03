﻿using System;
using System.Collections;
using System.Collections.Generic;
using Algorithms._interface;
using Algorithms.node;

namespace Algorithms._abstract
{
	public abstract class SearchTree<E, T> : IEnumerable<E>, IDefaultComparator<E>
		where T : TreeSearchNode<E>
	{
		protected T Root { get; set;}
		public int Length { get; protected set; }

		public abstract void Insert(E value);
		public abstract E Remove(E value);
		public abstract E Retrieve(E value);
		
		public bool Empty() => Length == 0;

		public Comparison<E> Comparator { get; set; }

		public abstract IEnumerator<E> GetEnumerator();

		IEnumerator IEnumerable.GetEnumerator()
		{
			throw new NotImplementedException();
		}
	}
}