using System;
using System.Collections;
using System.Collections.Generic;
using Algorithms.Interfaces;
using Algorithms.Nodes;

namespace Algorithms.Abstracts
{
	public abstract class SearchTreeBase<TType, TNode> : IEnumerable<TType>, IDefaultComparator<TType>
		where TNode : TreeSearchNode<TType>
	{
        /// <summary>
        /// Root não contém dados, é o "ponteiro" para o primeiro objeto da árvore.
        /// </summary>
		protected TNode Root { get; set;}
		public int Length { get; protected set; }
        public bool AllowUniqueObject { get; protected set; }

		public abstract void Insert(TType value);
		public abstract TType Remove(TType value);
		public abstract TType Retrieve(TType value);
		
		public bool IsEmpty() => Length == 0;

		public Comparison<TType> Comparator { get; set; }

		public abstract IEnumerator<TType> GetEnumerator();

		IEnumerator IEnumerable.GetEnumerator()
		{
			throw new NotImplementedException();
		}


        /// <summary>
        /// Encontra a posição anterior ao valor informado. 
        /// Caso não encontre o nó com o valor retorna a posição mais próxima a ele.
        /// <para>Complexidade de Tempo: O(log n).</para>
        /// </summary>
        protected TreeSearchNode<TType> FindPreviousNodeByValue(TType value)
        {
            TreeSearchNode<TType> searchNode = FirstNode;
            TreeSearchNode<TType> previousNode = searchNode;
            bool positionFound = false;

            while (!positionFound)
            {
                if (Comparator(searchNode.Value, value) > 0 && searchNode.HasLeft())
                {
                    previousNode = searchNode;
                    searchNode = searchNode.Left;
                }
                else if (Comparator(searchNode.Value, value) < 0 && searchNode.HasRight())
                {
                    previousNode = searchNode;
                    searchNode = searchNode.Right;
                }
                else 
                {
                    positionFound = true;// parar o loop.
                }
            }

            return previousNode;
        }

        /// <summary>
        /// Encontra a posição do nó de acordo com o valor informado.
        /// <para>Complexidade de Tempo: O(log n).</para>
        /// </summary>
        /// <param name="value"></param>
        /// <returns>Retorna</returns>
        protected TreeSearchNode<TType> FindNodeByValue(TType value)
        {
            TreeSearchNode<TType> searchNode = FirstNode;
            TreeSearchNode<TType> foundNode = null;
            bool positionFound = false;

            while (!positionFound)
            {
                if (Comparator(searchNode.Value, value) > 0 && searchNode.HasLeft())
                {
                    searchNode = searchNode.Left;
                }
                else if (Comparator(searchNode.Value, value) < 0 && searchNode.HasRight())
                {
                    searchNode = searchNode.Right;
                }
                else if (Comparator(searchNode.Value, value) == 0)
                {
                    foundNode = searchNode;
                    positionFound = true;// parar o loop.
                }
                else
                {
                    positionFound = true;// parar o loop.
                }
            }

            return foundNode;
        }

        protected TreeSearchNode<TType> FirstNode => Root.Father;
        
    }
}
