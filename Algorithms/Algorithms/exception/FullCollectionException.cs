using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.exception
{
	class FullCollectionException: Exception
	{
		private const string commonMessage = "A coleção de itens está cheia!";
		public FullCollectionException() : base(commonMessage) { }
		public FullCollectionException(string message) : base(message) { }

		// A constructor is needed for serialization when an
		// exception propagates from a remoting server to the client. 

	}
}
