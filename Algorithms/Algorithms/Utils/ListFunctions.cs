using System.Collections.Generic;

namespace Algorithms.Utils
{
    public static class ListFunctions
	{

        /// <summary>
        /// Faz a troca de dois objetos de um vetor.
        /// </summary>
        /// <typeparam name="E"> Tipo do objeto do vetor.</typeparam>
        /// <param name="list">Vetor de entrada.</param>
        /// <param name="X">Posição onde irá ser feita a troca.</param>
        /// <param name="Y">Posição onde irá ser feita a troca.</param>
        public static void Swap<T>(IList<T> list, int X, int Y)
        {
            T temp = list[X];
            list[X] = list[Y];
            list[Y] = temp;
        }
    }
}
