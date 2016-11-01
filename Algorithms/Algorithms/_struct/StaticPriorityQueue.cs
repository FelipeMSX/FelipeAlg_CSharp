using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms._struck;
using Algorithms.exception;

namespace Algorithms._struct
{
	class StaticPriorityQueue<E> : StaticQueue<E> where E : new()
	{
		public StaticPriorityQueue() : base(MAXSIZEDEFAULT)
		{
		}

		public StaticPriorityQueue(int maxSize): base(maxSize)
		{
		}

		public StaticPriorityQueue(int maxsize, bool resizable) : base(maxsize, resizable)
		{
		}

		public StaticPriorityQueue(int maxSize, Comparison<E> comparator) : base(maxSize ,comparator)
		{
		}

		public StaticPriorityQueue(int maxsize, bool resizable, Comparison<E> comparator) : base (maxsize, resizable, comparator)
		{
		}

		public override void Push(E obj)
		{
			if(obj == null)
			{
				throw new NullObjectException();
			}
			else
			{
				if (Full())
				{
					if (Resizable)
					{
						DoubleCapacity();
						int position = 0;
						//Encontra a posição do item a ser colocado.
						while (Length > 0 && Comparator(obj, Vector[position]) < 0)
							position++;

						//Desloca os itens uma posição a frente para colocar o objeto no lugar.
						for (int i = MaxSize - 1; i >= position; i--)
						{
							Vector[i + 1] = Vector[i];
						}

						Vector[position] = obj;
						Length++;
					}
					else
					{
						throw new FullCollectionException();
					}
				}
			}
		}
	}
}
