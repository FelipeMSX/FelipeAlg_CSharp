﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms._abstract
{
	/// <summary>
	/// Classe abstrata utilizada na criação de qualquer coleção que utilize uma pilha ou fila.
	/// </summary>
	/// <typeparam name="E">Tipo do objeto armazenado na coleção.</typeparam>
	public abstract class Queue_Stack<E> : StaticStruct<E>
	{

		public abstract void Push(E obj);
		public abstract E Pop();

		public Queue_Stack() : base()
		{
		}

		public Queue_Stack(int maxsize, bool resizable = true, Comparison<E> comparator = null) : base (maxsize, resizable, comparator)
		{
		}
	}
}
