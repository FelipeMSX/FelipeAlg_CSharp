﻿using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.node;
using Algorithms.exception;
using Algorithms._interface;
using System.Collections.Generic;
using System.Collections;

namespace Algorithms._abstract
{
	public abstract class LinkedStruct<E, T> : Common<E>
		where T: Node<E>
	{

		public LinkedStruct()
		{
			Head = default(T);
		}

		public abstract void Insert(E obj);
		public abstract E Remove(E obj);
		public abstract E First();

		public abstract E Last();

		public abstract E Retrive(E obj);

		public Comparison<E> Comparator { get; set; }
		protected T Head { get; set; }

		public int Length { get; protected set; }

		public void DisposeAll()
		{
			Head	= default(T);
			Length	= 0;
		}

		public bool Empty()
		{
			return Length == 0;
		}

		public abstract IEnumerator<E> GetEnumerator();


	}
}
