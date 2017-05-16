using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.util
{
	public static class Util
	{
		/// <summary>
		/// Faz a troca de dois objetos de um vetor.
		/// </summary>
		/// <typeparam name="E"> Tipo do objeto do vetor.</typeparam>
		/// <param name="vector">Vetor de entrada.</param>
		/// <param name="X">Posição onde irá ser feita a troca.</param>
		/// <param name="Y">Posição onde irá ser feita a troca.</param>
		public static void SwapItem<E>(E[] vector, int X, int Y)
		{
			E temp = vector[X];
			vector[X] = vector[Y];
			vector[Y] = temp;
		}
	}
}
