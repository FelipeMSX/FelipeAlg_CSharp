using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Abstacts;
using Algorithms.Exceptions;
using Algorithms.Nodes;

namespace Algorithms.Collections
{
    public class BinaryTree<T> : SearchTreeBase<T, TreeSearchNode<T>>
    {

        public BinaryTree(Comparison<T> comparison)
        {
            if (comparison == null)
            {
                throw new NullObjectException("The comparison object cannot be null");
            }

            Root = new TreeSearchNode<T>();
            Comparator = comparison;
        }

        private TreeSearchNode<T> FindPosition(T value)
        {
            TreeSearchNode<T> searchNode = GetFirstNode();
            bool positionFound = false;

            while (!positionFound)
            {
                if (Comparator(searchNode.Value, value) > 0)
                {
                    if (searchNode.HasLeft())
                        searchNode = searchNode.Left;
                    else
                        positionFound = true;
                }
                else if (Comparator(searchNode.Value, value) < 0)
                {
                    if (searchNode.HasRight())
                        searchNode = searchNode.Right;
                    else
                        positionFound = true;
                }
                else
                {
                    positionFound = true;
                }
            }
            return searchNode;
        }

        /// <summary>
        /// Impressão é da esquerda para à direita. Resultando na ordem crescente.
        /// </summary>
        /// <returns></returns>
        private IList<T> GenerateList()
        {
            List<T> list = new List<T>();
            GenerateListAuxiliar(GetFirstNode(), list);
            return list;
        }

        private void GenerateListAuxiliar(TreeSearchNode<T> currentNode, IList<T> list)
        {
            if (currentNode != null)
            {
                GenerateListAuxiliar(currentNode.Left, list);
                list.Add(currentNode.Value);
                GenerateListAuxiliar(currentNode.Right, list);
            }
        }

        private TreeSearchNode<T> GetFirstNode()
        {
            return Root.Father;
        }


        public override void Insert(T value)
        {
            TreeSearchNode<T> newNode = new TreeSearchNode<T>(value);

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
                TreeSearchNode<T> searchNode = FindPosition(value);

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


        public override T Remove(T value)
        {
            throw new NotImplementedException();
        }

        public override T Retrieve(T value)
        {
            //Validações
            if (value == null)
            {
                throw new NullObjectException();
            }
            else if (IsEmpty())
            {
                throw new EmptyCollectionException();
            }

            TreeSearchNode<T> searchNode = FindPosition(value);

            if(Comparator(searchNode.Value, value) != 0 )
            {
                throw new ElementNotFoundException();
            }

            return searchNode.Value;
        }

        public override IEnumerator<T> GetEnumerator()
        {
            foreach (T item in GenerateList())
            {
                yield return item;
            }
        }
    }
}
