using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.LINQ
{
	public static class LINQExtension
	{
		public static List<E> Filtrar<E>(this LINK<E> TSource, Func<E,bool> fu)
		{
			List<E> output = new List<E>();
			foreach (E value in TSource)
			{
				if (fu(value))
					output.Add(value);
			}
			return output;
		}

		public static List<T> Selecionar<E,T>(this LINK<E> TSource, Func<E, T> fu)
		{
			List<T> output = new List<T>();
			foreach (E value in TSource)
				output.Add(fu(value));

			return output;
		}
	}
}
