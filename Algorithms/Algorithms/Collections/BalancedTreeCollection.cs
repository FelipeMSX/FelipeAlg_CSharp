﻿using Algorithms.Abstracts;
using Algorithms.Exceptions;
using Algorithms.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Collections
{
    public class BalancedTreeCollection<TValue> : SearchTreeBase<TValue, TreeSearchNode<TValue>>
    {
        public BalancedTreeCollection(Comparison<TValue> comparator) : base(comparator)
        {
            Root = new TreeSearchNode<TValue>();
        }

        public override void Add(TValue value)
        {
            TreeSearchNode<TValue> newNode = new TreeSearchNode<TValue>(value);

            //Validações
            if (value == null)
                throw new NullObjectException();

            if (IsEmpty())
            {
                Root.Parent = newNode;
                Count++;
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
                Count++;
            }

        }

        public override bool Remove(TValue value)
        {
            throw new NotImplementedException();
        }
    }
}
