using System;
using Algorithms.Abstacts;
using Algorithms.Exceptions;

namespace Algorithms.Collections
{
    /// <summary>
    ///  Estrutura de dados que representa uma pilha.
    ///  <para>Características</para>
    ///  <para>1* Os objetos são colocados no final do vetor.</para>
    ///  <para>2*Ao retirada do objeto é feita no final do vetor.</para>
    /// </summary>
    /// <author>Felipe Morais</author>
    /// <email>felipemsx18@gmail.com</email>
    /// <typeparam name="E">Tipo de Objeto da pilha.</typeparam>
    public class StaticStack<E> : QueueStackBase<E> 
	{
        /// <summary>
        /// Inicializa a coleção com o tamanho padrão de 100, e por padrão seu tamanho é reajustável.
        /// </summary>
		public StaticStack() : base()
		{
		}

		/// <param name="maxsize">Valor máximo de itens que a coleção pode armazenar.</param>
		/// <param name="resizable">Define se a coleção deve se expandir ao atingir a capacidade máxima.</param>
		/// <param name="comparator">Fornece um método de comparação para os objetos da coleção.</param>
		public StaticStack(int maxsize, bool resizable = true, Comparison<E> comparator = null) : base (maxsize, resizable, comparator)
		{

		}


		/// <summary>
		///  Coloca um objeto
		/// </summary>
		/// <exception cref="NullObjectException">Objeto não pode ser nulo.</exception>
		/// <exception cref="FullCollectionException">A pilha está cheia e não aceita está configurada para ser redimensionada.</exception>
		/// <param name="obj">Objeto a ser inserido na coleção.</param>
		public override void Push(E obj)
		{
            //Validações
			if (obj == null)
				throw new NullObjectException();
			if (Full())
				IncreaseCapacity();

			Vector[Length++] = obj;
		}

		/// <summary>
		///  Remove o primeiro objeto da coleção.
		/// </summary>
		/// <exception cref="EmptyCollectionException">Não existe elemento para remover na pilha.</exception>
		/// <returns></returns>
		public override E Pop()
		{
			if (Empty())
				throw new EmptyCollectionException();

			E temp = Vector[--Length];
			Vector[Length] = default(E);

			return temp;
		}
	}
}
