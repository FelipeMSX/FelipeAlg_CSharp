using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.exception
{
	/// <summary>
	/// Será lançada uma exceção quando tentar inserir na coleção com sua capacidade no limite.
	/// </summary>
	class FullCollectionException: Exception
	{
		private const string commonMessage = "A coleção de itens está cheia!";
		public FullCollectionException() : base(commonMessage) { }
		public FullCollectionException(string message) : base(message) { }
	}
}
