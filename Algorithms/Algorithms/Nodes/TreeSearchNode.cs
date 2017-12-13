﻿using Algorithms.Abstacts;

namespace Algorithms.Nodes
{
	public class TreeSearchNode<E> : NodeBase<E>
	{
		/// <summary>
		/// Representa um ponteiro para um node anterior.
		/// </summary>
		public TreeSearchNode<E> Left { get; set; }

		/// <summary>
		/// Representa um ponteiro para um node posterior.
		/// </summary>
		public TreeSearchNode<E> Right { get; set; }

		/// <summary>
		/// Representa um ponteiro para um node pai.
		/// </summary>
		public TreeSearchNode<E> Father { get; set; }

		public TreeSearchNode() : base()
		{
		}

		/// <param name="obj">Objeto genérico que será armazenado no node.</param>
		public TreeSearchNode(E obj) : base(obj)
		{
		}

		/// <summary>
		/// Avalia se existe um próximo node.
		/// </summary>
		/// <returns>Retorna true se existir um próximo node, caso contrário, false.</returns>
		public bool HasRight() => Right != null;

		/// <summary>
		/// Avalia se existe um node anterior ao atual.
		/// </summary>
		/// <returns>Retorna true se existir um node anterior, caso contrário, false.</returns>
		public bool HasLeft() => Left != null;

		/// <summary>
		/// Avalia se existe um node anterior ao atual.
		/// </summary>
		/// <returns>Retorna true se existir um node anterior, caso contrário, false.</returns>
		public bool HasFather() => Father != null;
	}
}
