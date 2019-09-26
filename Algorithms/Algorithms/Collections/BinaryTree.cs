using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Abstracts;
using Algorithms.Exceptions;
using Algorithms.Nodes;

namespace Algorithms.Collections
{
    public class BinaryTreeCollection<TType> : SearchTreeBase<TType, TreeSearchNode<TType>>
    {

        public BinaryTreeCollection(Comparison<TType> comparison)
        {
            if (comparison == null)
            {
                throw new NullObjectException("The comparison object cannot be null");
            }

            Root = new TreeSearchNode<TType>();
            Comparator = comparison;
        }



        /// <summary>
        /// Impressão é da esquerda para à direita. Resultando na ordem crescente.
        /// </summary>
        /// <returns></returns>
        private IList<TType> GenerateList()
        {
            List<TType> list = new List<TType>();
            GenerateListAuxiliar(FirstNode, list);
            return list;
        }

        private void GenerateListAuxiliar(TreeSearchNode<TType> currentNode, IList<TType> list)
        {
            if (currentNode != null)
            {
                GenerateListAuxiliar(currentNode.Left, list);
                list.Add(currentNode.Value);
                GenerateListAuxiliar(currentNode.Right, list);
            }
        }

        public override void Insert(TType value)
        {
            TreeSearchNode<TType> newNode = new TreeSearchNode<TType>(value);

            //Validações
            if (value == null)
            {
                throw new NullObjectException();
            }

            if (IsEmpty())
            {
                Root.Father = newNode;
                Length++;
            }
            else
            {
                TreeSearchNode<TType> searchNode = FindPreviousNodeByValue(value);

                //Se chegar aqui deve ser inserido.
                if (Comparator(searchNode.Value, value) > 0)
                    searchNode.Left = newNode;
                else if (Comparator(searchNode.Value, value) < 0)
                    searchNode.Right = newNode;
                else
                    throw new EqualsElementException();

                newNode.Father = searchNode;
                Length++;
            }
        }


        public override TType Remove(TType value)
        {
            throw new NotImplementedException();
        }

        public override TType Retrieve(TType value)
        {
            //Validações
            if (value == null)
                throw new NullObjectException();
            else if (IsEmpty())
                throw new EmptyCollectionException();

            TreeSearchNode<TType> searchNode = FindNodeByValue(value);

            if (searchNode == null)
                throw new ElementNotFoundException();

            return searchNode.Value;
        }

        public override IEnumerator<TType> GetEnumerator()
        {
            foreach (TType item in GenerateList())
            {
                yield return item;
            }
        }
    }
}
