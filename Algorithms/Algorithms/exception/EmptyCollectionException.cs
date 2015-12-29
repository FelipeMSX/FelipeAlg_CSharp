using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.exception
{
	/// <summary>
	/// Uma exceção será lançada quando tentar acessar uma coleção vazia.
	/// </summary>
	class EmptyCollectionException: Exception
	{
		private const string commonMessage = "A coleção de itens está vazia!";
		public EmptyCollectionException() : base(commonMessage) { }
		public EmptyCollectionException(string message) : base(message) { }

		// A constructor is needed for serialization when an
		// exception propagates from a remoting server to the client. 

	}
}
