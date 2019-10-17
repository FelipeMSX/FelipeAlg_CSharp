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
    public class BinaryTreeCollection<TValue> : SearchTreeBase<TValue, TreeSearchNode<TValue>>
    {

        public BinaryTreeCollection(Comparison<TValue> comparison)
        {
            Root = new TreeSearchNode<TValue>();
            Comparator = comparison ?? throw new NullObjectException("The comparison object cannot be null");
        }



        /// <summary>
        /// Impressão é da esquerda para à direita. Resultando na ordem crescente.
        /// </summary>
        /// <returns></returns>
        private IList<TValue> GenerateList()
        {
            List<TValue> list = new List<TValue>();
            GenerateListAuxiliar(FirstNode, list);
            return list;
        }

        private void GenerateListAuxiliar(TreeSearchNode<TValue> currentNode, IList<TValue> list)
        {
            if (currentNode != null)
            {
                GenerateListAuxiliar(currentNode.Left, list);
                list.Add(currentNode.Value);
                GenerateListAuxiliar(currentNode.Right, list);
            }
        }

        public override void Insert(TValue value)
        {
            TreeSearchNode<TValue> newNode = new TreeSearchNode<TValue>(value);

            //Validações
            if (value == null)
                throw new NullObjectException();

            if (IsEmpty())
            {
                Root.Parent = newNode;
                Length++;
            }
            else
            {
                TreeSearchNode<TValue> searchNode = FindPreviousNodeByValue(value);

                //Se chegar aqui deve ser inserido.
                if (Comparator(searchNode.Value, value) > 0)
                    searchNode.Left = newNode;
                else if (Comparator(searchNode.Value, value) < 0)
                    searchNode.Right = newNode;
                else
                    throw new EqualsElementException();

                newNode.Parent = searchNode;
                Length++;
            }
        }


        public override TValue Remove(TValue value)
        {
            //Validações
            if (value == null)
                throw new NullObjectException();
            else if (IsEmpty())
                throw new EmptyCollectionException();

            TreeSearchNode<TValue> removeNode = FindNodeByValue(value);

            if(removeNode == null || Comparator(removeNode.Value,value) != 0)
                throw new ElementNotFoundException();

            //A partir daqui é pra remover o objeto.
            TValue foundValue = default;

            //Remover na Raiz
            if (Length == 1)
            {
                foundValue       = removeNode.Value;
                removeNode.Value = default;
                FirstNode        = null;
            }
            else
            {
                foundValue = removeNode.Value;
                EraseConections(removeNode);
            }

            Length--;

            return foundValue;
        }

        public override TValue Retrieve(TValue value)
        {
            //Validações
            if (value == null)
                throw new NullObjectException();
            else if (IsEmpty())
                throw new EmptyCollectionException();

            TreeSearchNode<TValue> searchNode = FindNodeByValue(value);

            if (searchNode == null)
                throw new ElementNotFoundException();

            return searchNode.Value;
        }

        public override IEnumerator<TValue> GetEnumerator()
        {
            foreach (TValue item in GenerateList())
            {
                yield return item;
            }
        }
    }
}
