using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms._interface;
using Algorithms.exception;

namespace Algorithms._abstract
{
	public class StaticStruct<E> : Common<E> 
	{
		public const int MAXSIZEDEFAULT = 100;
		protected Comparison<E> Comparator{ get; set; }

		protected E[] Vector { get; set; }

		public int Length { get; protected set; }

		private int maxSize;
		public int MaxSize
		{
			get { return maxSize; }
			set
			{
				if (value < maxSize)
					throw new ValueNotValidException("max size can't be less than current!");
				maxSize = value;
			}
		}

		protected int ResizeValue { get; set; }

		public bool Resizable { get; set; }

		public StaticStruct()
		{
			MaxSize		= MAXSIZEDEFAULT;
			ResizeValue = MAXSIZEDEFAULT;
			Vector		= new E[MaxSize];
			Resizable	= true; 
		}

		public StaticStruct(int maxSize, bool resizable = true, Comparison<E> comparator = null)
		{
			MaxSize		= maxSize;
			ResizeValue = MAXSIZEDEFAULT;
			Vector		= new E[MaxSize];
			Resizable	= resizable;
			Comparator	= comparator;
		}

		public void DisposeAll()
		{
			Vector = new E[MaxSize];
			Length = 0;
		}

		public E First()
		{
			return Empty() ? default(E) : Vector[0];
		}

		public bool Empty()
		{
			
			return Length == 0;
		}

		public E Last()
		{
			return Empty() ? default(E) : Vector[Length - 1];
		}

		public E Retrive(E obj)
		{
			if (Empty())
				throw new EmptyCollectionException();
			if (Comparator == null)
				throw new ComparerNotSetException();


			for (int i = 0; i < Length; i++)
			{
				if (Comparator(Vector[i], obj) == 0)
					return obj;
			}

			return default(E);
		}

		protected void DoubleCapacity()
		{
			if (Resizable)
				throw new FullCollectionException();

			MaxSize += ResizeValue;
			E[] temp = new E[MaxSize];

			for (int i = 0; i < Length; i++)
			{
				temp[i] = Vector[i];
			}
			Vector = temp;
		}

		public bool Full()
		{
			return Length == MaxSize;
		}
	}
}
